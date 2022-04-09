using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions;

public class AuctionMinOfferPriceMustBeLargerThanZeroException : BadRequestException
{
    public AuctionMinOfferPriceMustBeLargerThanZeroException(string message = "auction min offer price must be larger than zero") : base(message)
    {
    }
}
