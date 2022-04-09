using App.Application.Contracts.Common;
using App.Application.DTOs.Role;
using App.Domain.Exceptions.LogicalExceptions.RoleExceptions;
using App.Domain.Exceptions.LogicalExceptions.UserExceptions;
using App.Domain.Models.Users;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Identity
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly ILookupNormalizer _normalizer;


        public RoleService(RoleManager<IdentityRole> roleManager,
                           IMapper mapper,
                           UserManager<ApplicationUser> userManager,
                           ILookupNormalizer normalizer)
        {
            _roleManager = roleManager;
            _mapper = mapper;
            _userManager = userManager;
            _normalizer = normalizer;
        }

        public async Task<IEnumerable<GetRoleDto>> GetRoles(CancellationToken cancellationToken)
        {
            var roles = _roleManager.Roles.Where(role => role.Name != Roles.ADMIN_ROLE);

            var data = await _mapper.ProjectTo<GetRoleDto>(roles)
                                    .ToListAsync(cancellationToken);

            return data;
        }

        public async Task<IdentityRole> GetRole(string name, CancellationToken cancellationToken)
        {
            // var role = await _roleManager.Roles.Where(role => role.Name == name)
            //                                     .FirstOrDefaultAsync(cancellationToken);

            var role = await _roleManager.FindByNameAsync(name);

            if(role is null) throw new RoleNotFoundException();

            return role;
        }

        public async Task<string> GetUserRole(ApplicationUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            if (roles is null || !roles.Any()) throw new UserDoesNotHaveAnyRoleException();

            return roles.First();
        }

        public async Task AddUserToRole(ApplicationUser user, string role)
        {
            var normalizedRoleName = _normalizer.NormalizeName(role);

            await _userManager.AddToRoleAsync(user, normalizedRoleName);
        }
        
        public async Task<bool> IsInOneOfRoles(ApplicationUser user, params string[] roles)
        {
            foreach (var role in roles)
            {
                var result = await _userManager.IsInRoleAsync(user, role);

                if (result) return true;
            }

            return false;
        }
    }
}
