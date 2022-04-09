using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Domain.Models.Users;

namespace App.Domain.Models.Auctions.AuctionOffers
{
    public class AuctionOffer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        

        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


        public Guid AuctionId { get; set; }
        public Auction Auction { get; set; }

        public static AuctionOffer Factory(double price, string userId, Guid auctionId)
        {
            return new AuctionOffer
            {
                ApplicationUserId = userId,
                Price = price,
                AuctionId = auctionId
            };
        }
    }
}
