using Microsoft.AspNetCore.Identity;

namespace App.Infrastructure.Extensions;

public static class IdentityResultExtensions
{
    public static bool DidCompanyNameTakeBefore(this IdentityResult identityResult)
    {
        var result = identityResult.Errors.Any() && identityResult.Errors.First().Code == "DuplicateUserName";

        return result;
    }

    public static bool DidEmailTakeBefore(this IdentityResult identityResult)
    {
        var result = identityResult.Errors.Any() && identityResult.Errors.First().Code == "DuplicateEmail";

        return result;
    }
}
