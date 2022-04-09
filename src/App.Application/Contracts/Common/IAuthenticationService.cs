using App.Application.DTOs.User;
using App.Domain.Models.Users;

namespace App.Application.Contracts.Common;

public interface IAuthenticationService
{
    Task<ApplicationUser> GetCurrentUser(CancellationToken cancellationToken);

    Task<bool> IsInOneOfRoles(ApplicationUser user, params string[] roles);

    Task<UserInfoDto> RegisertCompany(CreateCompanyDto dto, CancellationToken cancellationToken);

    Task<UserInfoDto> RegisertCustomer(CreateUserDto dto, CancellationToken cancellationToken);

    Task<UserInfoDto> RegisertDriver(CreateDriverDto dto, CancellationToken cancellationToken);

    Task<UserInfoDto> Login(LoginUserDto dto, CancellationToken cancellationToken);
}
