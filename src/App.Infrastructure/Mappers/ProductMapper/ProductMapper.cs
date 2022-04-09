using System;
using App.Application.DTOs.Media;
using App.Application.DTOs.Product;
using App.Domain.Models.Products;
using App.Domain.Models.Products.Media;
using AutoMapper;

namespace App.Infrastructure.Mappers.ProductMapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<CreateProductDto, Product>()
                    .ForMember(product => product.ShopOwnerId, opt => opt.Ignore());

            CreateMap<UpdateProductDto, Product>();

            CreateMap<Product, GetProductDto>()
                    .BeforeMap((product, dto) =>
                    {
                        dto.Company = new();
                    })
                    .ForPath(dto => dto.Company.CompanyId, opt => opt.MapFrom(product => product.ShopOwnerId))
                    .ForPath(dto => dto.Company.CompanyName, opt => opt.MapFrom(product => product.ShopOwner.NormalizedUserName));

            CreateMap<Product, OrderProductInfoDto>()
                    .ForMember(product => product.ProductId, opt => opt.MapFrom(dto => dto.Id));

            CreateMap<Media, GetProductMediaInfo>()
                    .ForMember(dto => dto.Endpoint, opt => opt.MapFrom(media => $"dotnet/Ecommerce/api/media/DownloadMedia/{media.Id}"));

            CreateMap<Product, GetGeneralProductInfoDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price));
        }
    }
}
