using App.Domain.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DbContext.EntityTypeConigurations;

internal static class Ids
{
    internal static readonly Guid Admin_Id = Guid.NewGuid();
    internal static readonly Guid Customer_Id = Guid.NewGuid();
    internal static readonly Guid Shop_Owner_Id = Guid.NewGuid();
    internal static readonly Guid Driver_id = Guid.NewGuid();


    internal static readonly Guid Admin_Role_Id = Guid.NewGuid();
    internal static readonly Guid Customer_Role_Id = Guid.NewGuid();
    internal static readonly Guid Shop_Owner_Role_Id = Guid.NewGuid();
    internal static readonly Guid Driver_Role_Id = Guid.NewGuid();
}

public class RoleConfig : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(CreateRoles());
    }

    private IEnumerable<IdentityRole> CreateRoles()
    {
        return new List<IdentityRole>
            {
                new IdentityRole
                {
                Id = Ids.Customer_Role_Id.ToString(),
                Name = Roles.CUSTOMER_ROLE,
                NormalizedName = Roles.CUSTOMER_ROLE
                },
                new IdentityRole
                {
                Id = Ids.Admin_Role_Id.ToString(),
                Name = Roles.ADMIN_ROLE,
                NormalizedName = Roles.ADMIN_ROLE
                },
                new IdentityRole
                {
                Id = Ids.Shop_Owner_Role_Id.ToString(),
                Name = Roles.SHOP_OWNER_ROLE,
                NormalizedName = Roles.SHOP_OWNER_ROLE
                },
                new IdentityRole
                {
                Id = Ids.Driver_Role_Id.ToString(),
                Name = Roles.DRIVER_ROLE,
                NormalizedName = Roles.DRIVER_ROLE
                }
            };
    }
}

public class UserConfig : IEntityTypeConfiguration<ApplicationUser>
{
    private readonly PasswordHasher<ApplicationUser> _passwordHasher;

    public UserConfig()
    {
        _passwordHasher = new PasswordHasher<ApplicationUser>();
    }

    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.HasData(CreateClients());
    }

    private IEnumerable<ApplicationUser> CreateClients()
    {
        return new List<ApplicationUser>
            {
                CreateUser("admin", Ids.Admin_Id.ToString()),
                CreateUser("customer", Ids.Customer_Id.ToString()),
                CreateUser("shopOwner", Ids.Shop_Owner_Id.ToString()),
                CreateUser("driver", Ids.Driver_id.ToString())
            };
    }

    private ApplicationUser CreateUser(string name, string id)
    {
        var email = name + "@email.com";

        var user = new ApplicationUser
        {
            Id = id,
            UserName = name,
            NormalizedUserName = name.ToUpper(),
            Email = email,
            NormalizedEmail = email.ToUpper(),
            EmailConfirmed = true,
            LockoutEnabled = false,
            SecurityStamp = Guid.NewGuid().ToString()
        };

        user.PasswordHash = _passwordHasher.HashPassword(user, "0000");

        return user;
    }
}

public class UserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(CreateUserRole());
    }

    private IEnumerable<IdentityUserRole<string>> CreateUserRole()
    {
        return new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = Ids.Admin_Role_Id.ToString(),
                    UserId = Ids.Admin_Id.ToString()
                },
                new IdentityUserRole<string>
                {
                    RoleId = Ids.Customer_Role_Id.ToString(),
                    UserId = Ids.Customer_Id.ToString()
                },
                new IdentityUserRole<string>
                {
                    RoleId = Ids.Shop_Owner_Role_Id.ToString(),
                    UserId = Ids.Shop_Owner_Id.ToString()
                },
                new IdentityUserRole<string>
                {
                    RoleId = Ids.Driver_Role_Id.ToString(),
                    UserId = Ids.Driver_id.ToString()
                }
            };
    }
}
