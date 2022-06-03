using System;
using System.ComponentModel.DataAnnotations;
using App.Domain.Exceptions.LogicalExceptions.ProductExceptions;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace App.Application.DTOs.Product
{
    public class CreateProductDto : IRequest<uint>
    {

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        [Required]
        [Range(0, uint.MaxValue)]
        public uint Quantity { get; set; }

        [Required]
        public short CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        
        public IFormFile? Icon { get; set; }

        public IEnumerable<IFormFile?>? OtherMedia { get; set; }

        public void ValidateNewProduct()
        {
            ValidateNewProductsQuantity();
            ValidateNewProductPrice();
        }

        private void ValidateNewProductsQuantity()
        {
            if (Quantity <= 0) throw new ProductQuantityMustBeMoreThanZeroException();
        }

        private void ValidateNewProductPrice()
        {
            if(Price <= 0) throw new ProductPriceCanNotBeLessThanZeroException();
        }
    }
}
