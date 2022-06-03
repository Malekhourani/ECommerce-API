using App.Domain.Models.Products.Categories;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using App.Domain.Models.Discounts;
using App.Domain.Exceptions.LogicalExceptions.ProductExceptions;
using App.Domain.Models.Users;
using MediaModel = App.Domain.Models.Products.Media.Media;
using App.Domain.Models.Auctions;

namespace App.Domain.Models.Products
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public uint Quantity { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public short CategoryId { get; set; }
        public Category Category { get; set; }


        [ForeignKey("ShopOwner")]
        public string ShopOwnerId { get; set; }

        [ForeignKey("ShopOwnerId")]
        public ApplicationUser ShopOwner { get; set; }

        public ICollection<Auction> Auctions {get; set;}

        public ICollection<Discount> Discounts { get; set; }

        public ICollection<MediaModel> Media { get; set; }

        public static Product Factory(uint id, string name, double price, uint quantity, string description, short categoryId, string shopOwnerId)
        {
            return new Product
            {
                Id = id,
                Name = name,
                Price = price,
                Quantity = quantity,
                Description = description,
                CategoryId = categoryId,
                ShopOwnerId = shopOwnerId
            };
        }

        public double CalculateProductCost(uint requestedQuantity)
        {
            ValidateNewProductsQuantity(requestedQuantity);

            return requestedQuantity * Price;
        }

        public void ValidateNewProductsQuantity(uint newProductQuantity)
        {
            if (newProductQuantity <= 0) throw new ProductQuantityMustBeMoreThanZeroException();

            if (newProductQuantity > Quantity) throw new RequriedQuantityIsNotAvailableException();
        }

        public bool IsTheShopOwner(string userId) => ShopOwnerId == userId;
        
        public bool IsAbleToDeleteProduct(string userId, bool isAdmin) => IsTheShopOwner(userId) || isAdmin;
        
    }
}
