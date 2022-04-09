using System;
using System.ComponentModel.DataAnnotations;
using App.Application.DTOs.Product;

namespace App.Application.DTOs.Order
{
    public class AddNewProductToOrderDto
    {
        [Required]
        public Guid OrderId { get; set; }

        [Required]
        public OrderProductInfoDto NewProduct { get; set; }
    }
}
