using System;
using App.Application.DTOs.Role;
using App.Domain.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;

namespace App.Application.Contracts.Common
{
    public interface IRoleService
    {
        Task<IEnumerable<GetRoleDto>> GetRoles(CancellationToken cancellationToken);

        Task AddUserToRole(ApplicationUser user, string role);

        Task<string> GetUserRole(ApplicationUser user);

        Task<bool> IsInOneOfRoles(ApplicationUser user, params string[] roles);

        Task<IdentityRole> GetRole(string name, CancellationToken cancellationToken);
    }
}
