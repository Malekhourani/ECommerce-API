using App.Application.Contracts;
using App.Application.Contracts.Common;
using App.Application.DTOs.Category;
using App.Domain.Exceptions.LogicalExceptions.CategoryExceptions;
using App.Domain.Models.Products.Categories;
using TanvirArjel.EFCore.GenericRepository;

namespace App.Application.Services.CategoryServices
{
    public class CategoryService : IProductCategoryService
    {
        private readonly IDbService _dbService;
        private readonly IRepository _repo;

        public CategoryService(IDbService dbService, IRepository repo)
        {
            _dbService = dbService;
            _repo = repo;
        }

        public async Task<short> CreateCategory(CreateProductCategoryDto dto, CancellationToken cancellationToken)
        {
            await CheckIfThereIsACategoryWithTheSameName(dto.Name, cancellationToken);

            var id = await _dbService.CreateAsync<Category, CreateProductCategoryDto, short>(dto, cancellationToken);

            return id;
        }

        private async Task CheckIfThereIsACategoryWithTheSameName(string name, CancellationToken cancellationToken)
        {
            var category = await _repo.GetAsync<Category>(category => category.Name == name, cancellationToken);

            if(category is not null) throw new CategoryWithTheSameNameAlreadyExistsException();
        }

        public async Task UpdateCategory(UpdateProductCategoryDto dto, CancellationToken cancellationToken)
        {
            await CheckIfThereIsACategoryWithTheSameName(dto.Name, cancellationToken);

            await _dbService.UpdateAsync<Category, UpdateProductCategoryDto>(dto.Id, dto, cancellationToken);
        }

        public Task DeleteCategory(short id, CancellationToken cancellationToken)
        {
            return _dbService.DeleteAsync<Category>(id, cancellationToken);
        }

        public Task<IEnumerable<GetProductCategoryDto>> GetCategories(CancellationToken cancellationToken)
        {
            return _dbService.GetAllAsync<Category, GetProductCategoryDto>(cancellationToken);
        }
    }
}
