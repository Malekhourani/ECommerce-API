using System;

namespace App.Application.DTOs.AuctionParticipant
{
    public class AddAuctionParticipantDto
    {
        public Guid AuctionId { get; set; }
        public string ParticipantId { get; set; }
    }
}
