using App.Application.DTOs.Category;

namespace App.Application.Contracts
{
    public interface IProductCategoryService
    {
        Task<short> CreateCategory(CreateProductCategoryDto dto, CancellationToken cancellationToken);
        Task UpdateCategory(UpdateProductCategoryDto dto, CancellationToken cancellationToken);
        Task DeleteCategory(short id, CancellationToken cancellationToken);
        Task<IEnumerable<GetProductCategoryDto>> GetCategories(CancellationToken cancellationToken);
    }
}
