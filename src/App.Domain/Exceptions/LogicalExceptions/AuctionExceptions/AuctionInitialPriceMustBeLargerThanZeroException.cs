using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions;

public class AuctionInitialPriceMustBeLargerThanZeroException : BadRequestException
{
    public AuctionInitialPriceMustBeLargerThanZeroException(string message = "auction initial price must be larger than zero") : base(message)
    {
    }
}
