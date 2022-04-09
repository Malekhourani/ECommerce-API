using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.UserExceptions;

public class PasswordsMustBeIdenticalException : BadRequestException
{
    public PasswordsMustBeIdenticalException(string message = "Passwords Must Be Identical.") : base(message)
    {
    }
}
