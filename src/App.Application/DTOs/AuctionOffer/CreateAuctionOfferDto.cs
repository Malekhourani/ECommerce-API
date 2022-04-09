using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.AuctionOffer
{
    public class CreateAuctionOfferDto
    {
        [Required]
        public Guid AuctionId { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
    }
}
