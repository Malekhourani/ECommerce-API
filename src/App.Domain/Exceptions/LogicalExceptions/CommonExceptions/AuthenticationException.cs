using System;

namespace App.Domain.Exceptions.LogicalExceptions.CommonExceptions
{
    public class AuthenticationException : LogicalException
    {
        public AuthenticationException(string message) : base(message)
        {
        }
    }
}
