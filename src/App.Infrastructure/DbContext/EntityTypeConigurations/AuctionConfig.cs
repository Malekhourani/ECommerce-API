using System;
using App.Domain.Models.Auctions;
using App.Domain.Models.Auctions.AuctionOffers;
using App.Domain.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DbContext.EntityTypeConigurations
{
    public class AuctionConfig : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            builder.Property(e => e.Id)
                    .HasDefaultValueSql("gen_random_uuid()");
        }
    }
}
