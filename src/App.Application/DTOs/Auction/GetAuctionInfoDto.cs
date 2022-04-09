using App.Application.DTOs.AuctionOffer;
using App.Application.DTOs.Product;
using App.Application.DTOs.User;

namespace App.Application.DTOs.Auction
{
    public class GetAuctionInfoDto
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsClosed { get; set; }
        public DateTime EndDate { get; set; }
        public double? FinalPrice { get; set; }
        public double InitialPrice { get; set; }
        public double? MinOfferPrice { get; set; } = null;
        public GetApplicationUserInfoDto Winner { get; set; }
        public GetGeneralProductInfoDto Product { get; set; }
        public IEnumerable<GetAuctionOfferDto> Offers { get; set; }
        public GetApplicationUserInfoDto Creator { get; set; }
    }
}
