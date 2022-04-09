using App.Application.DTOs.Product;
using App.Application.DTOs.User;

namespace App.Application.DTOs.Auction;

public class GetActiveAuctionDto
{
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double InitialPrice { get; set; }
        public double? MinOfferPrice { get; set; } = null;
        public GetGeneralProductInfoDto Product { get; set; }
        public GetApplicationUserInfoDto Creator { get; set; }
}
