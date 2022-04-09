using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.MediaExceptions;

public class AlreadyThePrimaryMediaException : BadRequestException
{
    public AlreadyThePrimaryMediaException(string message = "The Current Media Already The Primary Media!") : base(message)
    {
    }
}
