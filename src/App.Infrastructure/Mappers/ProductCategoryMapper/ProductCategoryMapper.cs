using App.Application.DTOs.Category;
using App.Domain.Models.Products.Categories;
using AutoMapper;

namespace App.Infrastructure.Mappers.ProductCategoryMapper
{
    public class ProductCategoryMapper : Profile
    {
        public ProductCategoryMapper()
        {
            CreateMap<CreateProductCategoryDto, Category>();

            CreateMap<UpdateProductCategoryDto, Category>();

            CreateMap<Category, GetProductCategoryDto>();
        }
    }
}
