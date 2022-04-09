using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions
{
    public class NewOfferShouldBeHigherThanLastOfferException : BadRequestException
    {
        public NewOfferShouldBeHigherThanLastOfferException(string message = "Can't Create This Offer, Because it is Less than The Last Offer.") : base(message)
        {
            
        }
    }
}
