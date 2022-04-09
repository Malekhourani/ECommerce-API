using System;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace App.Application.DTOs.Product
{
    public class UpdateProductDto : IRequest
    {
        public uint Id { get; set; }
        
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

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
