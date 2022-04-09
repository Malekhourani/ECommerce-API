using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.UserExceptions
{
    public class BadEmailOrPasswordException : BadRequestException
    {
        public BadEmailOrPasswordException(string message = "Bad Email or Password.") : base(message)
        {
            
        }
    }
}
