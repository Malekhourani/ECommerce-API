using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.User
{
    public class UserDidnotLoginException : AuthenticationException
    {
        public UserDidnotLoginException(string message = "You Need to Login to get Access to this Data.") : base(message)
        {
            
        }
    }
}
