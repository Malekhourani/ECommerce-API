using App.Domain.Models.Auctions;
using App.Domain.Models.Auctions.AuctionOffers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DbContext.EntityTypeConigurations
{
    public class AuctionLogConfig : IEntityTypeConfiguration<AuctionOffer>
    {
        public void Configure(EntityTypeBuilder<AuctionOffer> builder)
        {
            builder.Property(e => e.Id)
                    .HasDefaultValueSql("gen_random_uuid()");

            
            builder.HasOne<Auction>(auction => auction.Auction)
                    .WithMany(auction => auction.AuctionOffers)
                    .HasForeignKey(auction => auction.AuctionId);
        }
    }
}
