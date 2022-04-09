using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.Category
{
    public class UpdateProductCategoryDto
    {
        [Required]
        public short Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
    }
}
