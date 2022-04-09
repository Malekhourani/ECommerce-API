using System;
using App.Domain.Models.Discounts.UserDiscounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DbContext.EntityTypeConigurations
{
    public class UserDiscountConfig : IEntityTypeConfiguration<UserDiscount>
    {
        public void Configure(EntityTypeBuilder<UserDiscount> builder)
        {
            builder.HasKey(obj => new
            {
                obj.ApplicationUserId,
                obj.DiscountId
            });
        }
    }
}
