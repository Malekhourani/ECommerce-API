using System;

namespace App.Domain.Exceptions.LogicalExceptions.CommonExceptions
{
    public class BadRequestException : LogicalException
    {
        public BadRequestException(string message) : base(message)
        {
        }
    }
}
