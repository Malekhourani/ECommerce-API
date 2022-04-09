using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions;

public class AuctionDoesnotHaveAnyOfferYetException : BadRequestException
{
    public AuctionDoesnotHaveAnyOfferYetException(string message = "You can\'t mark an auction as sold before it gets any offers") : base(message)
    {
    }
}
