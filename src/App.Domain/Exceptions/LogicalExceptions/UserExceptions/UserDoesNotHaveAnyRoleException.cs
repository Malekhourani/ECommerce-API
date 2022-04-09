using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.UserExceptions
{
    public class UserDoesNotHaveAnyRoleException : AuthorizationException
    {
        public UserDoesNotHaveAnyRoleException(string message = "User Does Not Have Any Role") : base(message)
        {
        }
    }
}
