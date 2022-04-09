using System;
using App.Application.Contracts.Common;
using App.Application.DTOs.Product;
using App.Application.Extensions;
using App.Domain.Exceptions.LogicalExceptions.ProductExceptions;
using App.Domain.Models.Products;
using AutoMapper;
using MediatR;

namespace App.Application.Services.ProductServices.Commands.UpdateProduct
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductDto>
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IAuthenticationService _authService;

        public UpdateProductHandler(IDbService dbService, IMapper mapper, IAuthenticationService authService)
        {
            _dbService = dbService;
            _mapper = mapper;
            _authService = authService;
        }


        //TODO: Be Explicit, Create Update Quantity Action Instead Of Updating it From Here.
        public async Task<Unit> Handle(UpdateProductDto request, CancellationToken cancellationToken)
        {
            var userId = await _authService.GetCurrentUserId(cancellationToken);

            var product = await _dbService.GetByIdAsync<Product>(request.Id, cancellationToken);

            if (!product.IsTheShopOwner(userId)) throw new OnlyTheShopOwnerCanUpdateProductInfoException();

            product.ValidateNewProductsQuantity(request.Quantity);

            var newProductInfo = _mapper.Map<UpdateProductDto, Product>(request);

            await _dbService.UpdateAsync<Product>(newProductInfo, cancellationToken);

            return Unit.Value;
        }
    }
}
