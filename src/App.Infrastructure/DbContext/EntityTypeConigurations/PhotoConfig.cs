using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MediaModel = App.Domain.Models.Products.Media.Media;

namespace App.Infrastructure.DbContext.EntityTypeConigurations;
public class PhotoConfig : IEntityTypeConfiguration<MediaModel>
{
    public void Configure(EntityTypeBuilder<MediaModel> builder)
    {
        builder.Property(e => e.Id)
                    .HasDefaultValueSql("gen_random_uuid()");
    }
}