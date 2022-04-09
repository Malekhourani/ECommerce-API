using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions
{
    public class AuctionHasAlreadyEndedException : BadRequestException
    {
        public AuctionHasAlreadyEndedException(string message = "Can't Create an Offer, Because Auction Has Already Ended.") : base(message)
        {
            
        }
    }
}
