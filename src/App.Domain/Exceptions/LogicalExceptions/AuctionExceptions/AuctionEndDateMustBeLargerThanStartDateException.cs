using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions;

public class AuctionEndDateMustBeLargerThanStartDateException : BadRequestException
{
    public AuctionEndDateMustBeLargerThanStartDateException(string message = "auction end date must be larger than start date") : base(message)
    {
    }
}
