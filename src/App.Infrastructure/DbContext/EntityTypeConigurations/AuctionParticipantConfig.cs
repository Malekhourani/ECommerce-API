using System;
using App.Domain.Models.Auctions.AuctionParticipants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DbContext.EntityTypeConigurations
{
    public class AuctionParticipantConfig : IEntityTypeConfiguration<AuctionParticipant>
    {
        public void Configure(EntityTypeBuilder<AuctionParticipant> builder)
        {
            builder.HasKey(auctionParticipant => new
            {
                auctionParticipant.AuctionId,
                auctionParticipant.ApplicationUserId
            });
        }
    }
}
