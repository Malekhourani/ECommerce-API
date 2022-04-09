using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.UserExceptions;

public class CompanyNameAlreadyTakenException : BadRequestException
{
    public CompanyNameAlreadyTakenException(string message = "Company Name Already Taken") : base(message)
    {
    }
}
