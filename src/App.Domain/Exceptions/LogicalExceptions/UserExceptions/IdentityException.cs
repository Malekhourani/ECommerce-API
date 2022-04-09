using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.UserExceptions;

public class IdentityException : BadRequestException
{
    public IdentityException(string message) : base(message)
    {
    }
}
