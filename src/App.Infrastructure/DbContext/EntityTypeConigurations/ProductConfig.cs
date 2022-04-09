using Faker;
using App.Domain.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DbContext.EntityTypeConigurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            SeedProductTable(builder);
        }

        private void SeedProductTable(EntityTypeBuilder<Product> builder)
        {
            // var products = Enumerable.Range(0, 134).Select(id =>
            // {
            //     var identityValue = ((uint)RandomNumber.Next());

            //     if (identityValue == 0) identityValue = ((uint)RandomNumber.Next());


            //     return Product.Factory(
            //                             identityValue,
            //                             Name.First(),
            //                              ((double)Faker.Finance.Coupon()),
            //                               ((uint)RandomNumber.Next()),
            //                                Lorem.Sentence(5),
            //                                 (short)(RandomNumber.Next(1, 4)),
            //                                 Ids.Shop_Owner_Id.ToString()
            //                                 );
            // });

            // builder.HasData(products);
        }
    }
}
