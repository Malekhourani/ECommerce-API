using System;
using App.Application.Contracts.Common;
using App.Domain.Exceptions.LogicalExceptions.User;

namespace App.Application.Extensions
{
    public static class IAuthenticationServiceExtensions
    {
        public static async Task<string> GetCurrentUserId(this IAuthenticationService authService, CancellationToken cancellationToken)
        {
            var user = await authService.GetCurrentUser(cancellationToken);
            
            return user.Id;
        }
    }
}
