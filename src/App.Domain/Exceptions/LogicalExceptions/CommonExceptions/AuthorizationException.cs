using System;

namespace App.Domain.Exceptions.LogicalExceptions.CommonExceptions
{
    public class AuthorizationException : LogicalException
    {
        public AuthorizationException(string message) : base(message)
        {
        }
    }
}
