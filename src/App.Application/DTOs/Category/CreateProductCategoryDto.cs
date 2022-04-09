using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.Category
{
    public class CreateProductCategoryDto
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
    }
}
