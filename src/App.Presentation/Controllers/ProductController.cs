using System;
using App.Application.Contracts;
using App.Application.DTOs.Common;
using App.Application.DTOs.Product;
using App.Domain.Models.Users;
using App.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Presentation.Controllers
{
    public class ProductController : BaseController<IProductService>
    {
        public ProductController(IProductService service) : base(service)
        {
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<Response> GetProducts(GetPageWithFilteringDto dto, CancellationToken cancellationToken)
        {
            return await Ok<GetPageWithFilteringDto, PageResultDto>(
                _service.GetProducts,
                dto,
                cancellationToken
                );
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<Response> GetProductsByCategory(GetPageByCategoryDto dto, CancellationToken cancellationToken)
        {
            return await Ok<GetPageByCategoryDto, PageResultDto>(
                _service.GetProductsByCategory,
                dto,
                cancellationToken
                );
        }

        [Authorize(Policy = Roles.SHOP_OWNER_ROLE)]
        [HttpPost]
        public async Task<Response> GetCurrentCompanyProducts(GetPageByCategoryDto dto, CancellationToken cancellationToken)
        {
            return await Ok<GetPageByCategoryDto, PageResultDto>(
                _service.GetCurrentCompanyProducts,
                dto,
                cancellationToken
                );
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<Response> GetProduct(uint id, CancellationToken cancellationToken)
        {
            return await Ok<uint, GetProductDto>(
                _service.GetProductById,
                id,
                cancellationToken
                );
        }
        

        [Authorize(Policy = Roles.SHOP_OWNER_ROLE)]
        [HttpPost]
        public async Task<Response> CreateProduct([FromForm] CreateProductDto dto, CancellationToken cancellationToken)
        {
            return await Ok<CreateProductDto, IFormFile, IEnumerable<IFormFile>, uint>(
                _service.CreateProduct,
                dto,
                dto?.Icon,
                dto?.OtherMedia,
                cancellationToken
            );
        }


        [Authorize(Policy = Roles.SHOP_OWNER_ROLE)]
        [HttpPut]
        public async Task<Response> UpdateProduct(UpdateProductDto dto, CancellationToken cancellationToken)
        {
            return await NoContent<UpdateProductDto>(
                _service.UpdateProduct,
                dto,
                cancellationToken
            ); 
        }

        [Authorize(Policy = "ShopOwnerOrAdmin")]
        [HttpDelete]
        public async Task<Response> DeleteProduct(uint id, CancellationToken cancellationToken)
        {
            return await NoContent<uint>(
                _service.DeleteProduct,
                id,
                cancellationToken
            );
        }
    }
}
