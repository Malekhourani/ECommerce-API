using App.Application.DTOs.Common;
using App.Application.DTOs.Product;
using App.Domain.Models.Products;
using Microsoft.AspNetCore.Http;

namespace App.Application.Contracts
{
    public interface IProductService
    {
        Task<uint> CreateProduct(CreateProductDto dto, IFormFile icon, IEnumerable<IFormFile> media, CancellationToken cancellationToken);

        Task UpdateProduct(UpdateProductDto request, CancellationToken cancellationToken);

        Task DeleteProduct(uint id, CancellationToken cancellationToken);

        Task<PageResultDto> GetProducts(GetPageWithFilteringDto dto, CancellationToken cancellationToken);

        Task<IEnumerable<Product>> GetProducts(IEnumerable<uint> productIds, CancellationToken cancellationToken);
        Task<Product> GetProduct(uint id, CancellationToken cancellationToken);
        Task<GetProductDto> GetProductById(uint id, CancellationToken cancellationToken);
        Task<PageResultDto> GetProductsByCategory(GetPageByCategoryDto dto, CancellationToken cancellationToken);
        Task<PageResultDto> GetCurrentCompanyProducts(GetPageWithFilteringDto dto, CancellationToken cancellationToken);
    }
}
