using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.Product
{
    public class OrderProductInfoDto
    {

        [Required]
        public uint ProductId { get; set; }

        [Required]
        public uint Quantity { get; set; }
    }
}
