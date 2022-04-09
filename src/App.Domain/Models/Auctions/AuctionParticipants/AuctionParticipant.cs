using App.Domain.Models.Users;

namespace App.Domain.Models.Auctions.AuctionParticipants
{
    public class AuctionParticipant
    {
        public Guid AuctionId { get; set; }
        public Auction Auction { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public static AuctionParticipant Factory(Guid auctionId, string userId)
        {
            return new AuctionParticipant 
            {
                ApplicationUserId = userId,
                AuctionId = auctionId
            };
        }
    }
}
