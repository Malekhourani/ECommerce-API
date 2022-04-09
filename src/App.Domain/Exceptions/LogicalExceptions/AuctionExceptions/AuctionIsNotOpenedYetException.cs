using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions
{
    public class AuctionIsNotOpenedYetException : BadRequestException
    {
        public AuctionIsNotOpenedYetException(string message = "Can't Create An Offer, Because This Auction Is Not Opened Yet.") : base(message)
        {
            
        }
    }
}
