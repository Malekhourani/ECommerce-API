using System;
using App.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;

namespace App.Infrastructure.Identity.Extensions
{
    public static class IdentityErrorExtensions
    {
        public static AggregateException ToAggregateException(this IEnumerable<IdentityError> errors)
        {
            return errors.Select(error => error.Description)
                            .ToAggregateException();
        }

        public static string ExtractErrorMessages(this IEnumerable<IdentityError> errors)
        {
            var message = string.Empty;

            errors.ToList().ForEach(error => 
            {
                message += error.Code + ":" + error.Description + "\n";
            });

            return message;
        }
    }
}
