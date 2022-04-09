using System;
using App.Domain.Exceptions.LogicalExceptions.AuctionExceptions;

namespace App.Application.DTOs.Auction
{
    public class CreateAuctionDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double InitialPrice { get; set; }

        public uint ProductId { get; set; }
        public double? MinOfferPrice { get; set; }

        public void Validate()
        {
            if(StartDate >= EndDate) throw new AuctionEndDateMustBeLargerThanStartDateException();

            if(InitialPrice < 0.0) throw new AuctionInitialPriceMustBeLargerThanZeroException();

            if(MinOfferPrice.HasValue && MinOfferPrice <= 0.0) throw new AuctionMinOfferPriceMustBeLargerThanZeroException();
        }
    }
}
