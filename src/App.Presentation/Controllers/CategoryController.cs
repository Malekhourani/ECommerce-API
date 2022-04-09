using App.Application.Contracts;
using App.Application.DTOs.Category;
using App.Application.DTOs.Common;
using App.Domain.Models.Users;
using App.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Presentation.Controllers
{
    [Authorize(Policy = Roles.ADMIN_ROLE)]
    public class CategoryController : BaseController<IProductCategoryService>
    {
        public CategoryController(IProductCategoryService service) : base(service)
        {
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<Response> GetCategories(CancellationToken cancellationToken)
        {
            return await Ok<IEnumerable<GetProductCategoryDto>>(
                _service.GetCategories,
                cancellationToken
                );
        }

        [HttpPost]
        public async Task<Response> CreateCategory(CreateProductCategoryDto dto, CancellationToken cancellationToken)
        {
            return await Ok<CreateProductCategoryDto, short>(
                _service.CreateCategory,
                dto,
                cancellationToken
            );
        }

        [HttpPut]
        public async Task<Response> UpdateCategory(UpdateProductCategoryDto dto, CancellationToken cancellationToken)
        {
            return await NoContent<UpdateProductCategoryDto>(
                _service.UpdateCategory,
                dto,
                cancellationToken
            );
        }

        [HttpDelete]
        public async Task<Response> DeleteCategory(short id, CancellationToken cancellationToken)
        {
            return await NoContent<short>(
                _service.DeleteCategory,
                id,
                cancellationToken
            );
        }
    }
}
