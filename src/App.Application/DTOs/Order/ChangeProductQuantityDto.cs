using System;
using System.ComponentModel.DataAnnotations;
using App.Application.DTOs.Product;

namespace App.Application.DTOs.Order
{
    public class ChangeProductQuantityDto
    {
        [Required]
        public Guid OrderId { get; init; }

        [Required]
        public OrderProductInfoDto Product { get; init; }
    }
}
