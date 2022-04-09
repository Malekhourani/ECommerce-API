using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Domain.Exceptions.LogicalExceptions.AuctionExceptions;
using App.Domain.Models.Auctions.AuctionOffers;
using App.Domain.Models.Auctions.AuctionParticipants;
using App.Domain.Models.Common;
using App.Domain.Models.Products;
using App.Domain.Models.Users;

namespace App.Domain.Models.Auctions
{
    //TODO: Add Creator ID
    //TODO: Add the min offer's price
    public class Auction : DeletableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }
        public bool IsClosed { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("WinnerOffer")]
        public Guid? WinnerOfferId { get; set; }

        [ForeignKey("WinnerOfferId")]
        public AuctionOffer WinnerOffer { get; set; }

        public double InitialPrice { get; set; }
        public double? MinOfferPrice { get; set; } = null;

        [ForeignKey("Creator")]
        public string CreatorId { get; set; } = null;

        [ForeignKey("CreatorId")]
        public ApplicationUser Creator { get; set; }
        
        public uint ProductId { get; set; }
        public Product Product { get; set; }

        public virtual ICollection<AuctionOffer> AuctionOffers { get; set; }
        public virtual ICollection<AuctionParticipant> AuctionParticipants { get; set; }

        public static Auction Factory(DateTime startDate, DateTime endDate, double initialPrice, double? minOfferPrice, uint productId, string creatorId)
        {
            return new Auction
            {
                StartDate = startDate,
                EndDate = endDate,
                InitialPrice = initialPrice,
                MinOfferPrice = minOfferPrice,
                ProductId = productId,
                CreatorId = creatorId
            };
        }

        public bool IsStarted()
        {
            return StartDate <= DateTime.Now;
        }

        public void CheckIfCanAcceptNewOffers()
        {
            if (!IsStarted()) throw new AuctionIsNotOpenedYetException();

            if (IsClosed) throw new AuctionHasAlreadyEndedException();
        }

        public bool IsFinished()
        {
            return IsClosed || DateTime.Now >= EndDate;
        }

        public void MarkAsSold()
        {
            if (IsClosed) throw new AuctionHasAlreadyEndedException();

            if (!AuctionOffers.Any()) throw new AuctionDoesnotHaveAnyOfferYetException();

            IsClosed = true;
            WinnerOfferId = AuctionOffers.Last().Id;
        }

        public void ValidateNewOffer(double newOffer)
        {
            CompareNewOfferWithMinOfferPrice(newOffer);

            var lastOffer = AuctionOffers.LastOrDefault();

            if (lastOffer is null) CompareNewOfferWithTheInitialPrice(newOffer);

            CompareNewOfferWithLastOffer(newOffer, lastOffer!.Price);
        }

        private void CompareNewOfferWithMinOfferPrice(double newOffer)
        {
            if (MinOfferPrice < newOffer) throw new NewOfferShouldBeHigherThanMinOfferPriceException();
        }

        private void CompareNewOfferWithTheInitialPrice(double newOffer)
        {
            if (newOffer <= InitialPrice)
                throw new NewOfferShouldBeHigherThanTheInitialPriceException();
        }

        private void CompareNewOfferWithLastOffer(double newOffer, double lastOffer)
        {
            if (newOffer <= lastOffer)
                throw new NewOfferShouldBeHigherThanLastOfferException();
        }
    }
}
