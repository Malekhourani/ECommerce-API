using App.Domain.Models.Products.Categories;
using Faker;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DbContext.EntityTypeConigurations
{
    public class PrductCategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            SeedCategoryTable(builder);
        }

        private static void SeedCategoryTable(EntityTypeBuilder<Category> builder)
        {
            var categories = new List<Category>
            {
                new Category {Id = 1, Name = "Clothes"},
                new Category {Id = 2, Name = "Grocery"},
                new Category {Id = 3, Name = "Barkery"},
                new Category {Id = 4, Name = "Makeup"},
                new Category {Id = 5, Name = "Bags"},
                new Category {Id = 6, Name = "Furniture"},
            };

            builder.HasData(categories);
        }
    }
}
