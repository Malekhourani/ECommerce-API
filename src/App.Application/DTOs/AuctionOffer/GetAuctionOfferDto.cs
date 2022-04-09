using System;
using App.Application.DTOs.User;

namespace App.Application.DTOs.AuctionOffer
{
    public class GetAuctionOfferDto
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public GetApplicationUserInfoDto Paticipant { get; set; }
        public Guid AuctionId { get; set; }
    }
}
