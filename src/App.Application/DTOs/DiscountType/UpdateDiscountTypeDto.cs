using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.DiscountType
{
    public class UpdateDiscountTypeDto
    {
        public short Id { get; set; }

        [MaxLength(25)]
        [Required]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
