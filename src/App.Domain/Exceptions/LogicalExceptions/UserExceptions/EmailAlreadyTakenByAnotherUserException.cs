using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.UserExceptions;

public class EmailAlreadyTakenByAnotherUserException : BadRequestException
{
    public EmailAlreadyTakenByAnotherUserException(string message = "Email already Taken By Another User.") : base(message)
    {
    }
}
