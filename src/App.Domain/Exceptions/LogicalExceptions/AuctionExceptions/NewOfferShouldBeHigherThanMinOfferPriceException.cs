using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions;

public class NewOfferShouldBeHigherThanMinOfferPriceException : BadRequestException
{
    public NewOfferShouldBeHigherThanMinOfferPriceException(string message = "Can't Create This Offer, Because it is Less than The Min Offer Price.") : base(message)
    {
    }
}
