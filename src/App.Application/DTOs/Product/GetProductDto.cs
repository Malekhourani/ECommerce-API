using System;
using System.ComponentModel.DataAnnotations;
using App.Application.DTOs.Category;
using App.Application.DTOs.Company;
using App.Application.DTOs.Media;

namespace App.Application.DTOs.Product
{
    public class GetProductDto
    {
        public uint Id { get; set; }
        
        public string Name { get; set; }

        public double Price { get; set; }

        public uint Quantity { get; set; }
        
        public GetProductCategoryDto Category { get; set; }
        public string Description { get; set; }
        public GetCompanyGeneralInfoDto Company { get; set; }
        public ICollection<GetProductMediaInfo> Media { get; set; }
    }
}
