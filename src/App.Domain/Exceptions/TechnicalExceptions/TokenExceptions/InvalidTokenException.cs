using System;

namespace App.Domain.Exceptions.TechnicalExceptions.TokenExceptions
{
    public class InvalidTokenException : TechnicalException
    {
        public InvalidTokenException(string message = "Invalid Token") : base(message)
        {
        }
    }
}
