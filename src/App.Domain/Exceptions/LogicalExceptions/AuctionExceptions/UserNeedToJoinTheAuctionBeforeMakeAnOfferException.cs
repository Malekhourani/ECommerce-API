using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.AuctionExceptions
{
    public class UserNeedToJoinTheAuctionBeforeMakeAnOfferException : AuthorizationException
    {
        public UserNeedToJoinTheAuctionBeforeMakeAnOfferException(string message = "Can't Create This Offer, Because You are Not a Participant.") : base(message)
        {
            
        }
    }
}
