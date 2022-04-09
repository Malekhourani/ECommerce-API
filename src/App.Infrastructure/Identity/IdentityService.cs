using App.Application.Contracts.Common;
using App.Application.DTOs.User;
using App.Domain.Models.Users;
using App.Infrastructure.Identity.Extensions;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using App.Services.Validation;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using App.Domain.Exceptions.LogicalExceptions.UserExceptions;
using TanvirArjel.EFCore.GenericRepository;
using System.Data;
using App.Domain.Exceptions.TechnicalExceptions.TokenExceptions;
using App.Domain.Exceptions.LogicalExceptions.User;
using App.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using App.Services.Hashing;

namespace App.Infrastructure
{
    public class IdentityService : IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        private readonly ILookupNormalizer _normalizer;
        private readonly IConfiguration _config;
        private readonly IRepository _repo;

        public IdentityService(UserManager<ApplicationUser> userManager,
                               IHttpContextAccessor httpContextAccessor,
                               SignInManager<ApplicationUser> signInManager,
                               IMapper mapper,
                               IRoleService roleService,
                               ILookupNormalizer normalizer,
                               IConfiguration config, IRepository repo)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _signInManager = signInManager;
            _mapper = mapper;
            _roleService = roleService;
            _normalizer = normalizer;
            _config = config;
            _repo = repo;
        }

        public async Task<UserInfoDto> Login(LoginUserDto dto, CancellationToken cancellationToken)
        {
            if (!RegexHelper.IsEmail(dto.Email)) throw new BadEmailOrPasswordException();

            var normalizedEmail = _normalizer.NormalizeEmail(dto.Email);

            var user = await _userManager.Users.Where(us => us.NormalizedEmail == normalizedEmail)
                                                .FirstOrDefaultAsync(cancellationToken);

            if (user is null) throw new BadEmailOrPasswordException();

            var isCorrect = _userManager.PasswordHasher
                                    .VerifyHashedPassword(user, user.PasswordHash, dto.Password)
                                    .HasFlag(PasswordVerificationResult.Success);

            if (!isCorrect) throw new BadEmailOrPasswordException();

            var token = await GenerateJwtToken(user);

            return UserInfoDto.Factory(user.UserName, token);
        }

        public async Task<ApplicationUser> GetCurrentUser(CancellationToken cancellationToken)
        {
            var email = _httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "Email");

            if (email is null || string.IsNullOrWhiteSpace(email.Value)) throw new InvalidTokenException();

            var user = await _userManager.FindByEmailAsync(email.Value);

            if (user is null) throw new UserDidnotLoginException();

            return user;
        }

        public async Task<bool> IsInOneOfRoles(ApplicationUser user, params string[] roles)
        {
            return await _roleService.IsInOneOfRoles(user, roles);
        }

        public async Task<UserInfoDto> RegisertDriver(CreateDriverDto dto, CancellationToken cancellationToken)
        {
            var companyRole = await _roleService.GetRole(Roles.DRIVER_ROLE, cancellationToken);

            return await Regisert<CreateDriverDto>(dto, Roles.DRIVER_ROLE, cancellationToken);
        }

        public async Task<UserInfoDto> RegisertCompany(CreateCompanyDto dto, CancellationToken cancellationToken)
        {
            var companyRole = await _roleService.GetRole(Roles.SHOP_OWNER_ROLE, cancellationToken);

            return await Regisert<CreateCompanyDto>(dto, Roles.SHOP_OWNER_ROLE, cancellationToken);
        }

        public async Task<UserInfoDto> RegisertCustomer(CreateUserDto dto, CancellationToken cancellationToken)
        {
            var customerRole = await _roleService.GetRole(Roles.CUSTOMER_ROLE, cancellationToken);

            return await Regisert<CreateUserDto>(dto, Roles.CUSTOMER_ROLE, cancellationToken);
        }

        private async Task<UserInfoDto> Regisert<TUserDto>(TUserDto dto, string role, CancellationToken cancellationToken)
            where TUserDto : CreateUserDto
        {
            if(! dto.Password.Equals(dto.RePassword)) throw new PasswordsMustBeIdenticalException();

            if (!RegexHelper.IsEmail(dto.Email)) throw new BadEmailOrPasswordException();

            using var transaction = await _repo.BeginTransactionAsync(cancellationToken: cancellationToken);

            var user = await CreateNewAccount(dto, cancellationToken);

            await _roleService.AddUserToRole(user, role);

            await transaction.CommitAsync(cancellationToken);

            var token = await GenerateJwtToken(user);

            return UserInfoDto.Factory(user.UserName, token);
        }

        private async Task<ApplicationUser> CreateNewAccount<TUserDto>(TUserDto dto, CancellationToken cancellationToken)
                where TUserDto : CreateUserDto
        {
            await CheckIfEmailAlreadyTaken(dto);

            var user = _mapper.Map<TUserDto, ApplicationUser>(dto);

            // var keys = await _repo.InsertAsync<ApplicationUser>(user, cancellationToken);
            var identityResult = await _userManager.CreateAsync(user, user.PasswordHash);

            if(identityResult.DidCompanyNameTakeBefore()) throw new CompanyNameAlreadyTakenException();

            if(identityResult.DidEmailTakeBefore()) throw new EmailAlreadyTakenByAnotherUserException();

            if(! identityResult.Succeeded) throw new IdentityException(identityResult.Errors.ExtractErrorMessages());

            return user;
        }

        private async Task CheckIfEmailAlreadyTaken<TUserDto>(TUserDto dto) 
                where TUserDto : CreateUserDto
        {
            var normalizedEmail = _normalizer.NormalizeEmail(dto.Email);

            var userWithTheSameEmail = await _userManager.FindByEmailAsync(normalizedEmail);

            if (userWithTheSameEmail is not null) throw new EmailAlreadyTakenByAnotherUserException();
        }

        private async Task<string> GenerateJwtToken(ApplicationUser user)
        {
            // Now its ime to define the jwt token which will be responsible of creating our tokens
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var secretKey = _config.GetSection("Jwt:Secret");

            // We get our secret from the appsettings
            var key = Encoding.ASCII.GetBytes(secretKey.Value);

            var userRole = await _roleService.GetUserRole(user);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Role", userRole),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim("Email", user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }
            ),
                // the life span of the token needs to be shorter and utilise refresh token to keep the user signedin
                // but since this is a demo app we can extend it to fit our current need
                Expires = DateTime.UtcNow.AddHours(6),
                // here we are adding the encryption alogorithim information which will be used to decrypt our token
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);

            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }
    }
}