using Microsoft.EntityFrameworkCore;
using App.Domain.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using App.Domain.Models.Discounts.UserDiscounts;
using App.Domain.Models.Products;
using App.Domain.Models.Products.Categories;
using App.Domain.Models.Discounts;
using App.Domain.Models.Discounts.DiscountTypes;
using App.Domain.Models.Discounts.DiscountActivationInfo;
using App.Domain.Models.Discounts.DiscountActivationInfo.DiscountActivateCondition;
using App.Domain.Models.Orders;
using App.Domain.Models.Orders.OrderProducts;
using App.Domain.Models.Auctions;
using App.Infrastructure.DbContext.EntityTypeConigurations;
using System.Reflection;
using App.Domain.Models.Auctions.AuctionOffers;
using App.Domain.Models.Auctions.AuctionParticipants;
using MediaModel = App.Domain.Models.Products.Media.Media;

namespace App.Infrastructure
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MediaModel> Media { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<AuctionOffer> AuctionOffers { get; set; }
        public DbSet<AuctionParticipant> AuctionParticipants { get; set; }

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserDiscount> UserDiscounts { get; set; }
        public DbSet<DiscountType> DiscountTypes { get; set; }
        public DbSet<ActivationInfo> ActivationInfo { get; set; }
        public DbSet<ActivateCondition> ActivateConditions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {

            
            var assembly = Assembly.GetAssembly(typeof(ProductConfig));

            builder.ApplyConfigurationsFromAssembly(assembly);
            
            base.OnModelCreating(builder);
        }
    }
}