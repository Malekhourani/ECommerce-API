using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions
{
    public class NewOfferShouldBeHigherThanTheInitialPriceException : BadRequestException
    {
        public NewOfferShouldBeHigherThanTheInitialPriceException(string message = "Can't Create This Offer, Because it is Less than The Initial Price") : base(message)
        {
            
        }
    }
}
