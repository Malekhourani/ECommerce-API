using System;
using App.Application.Contracts.Common;
using App.Application.DTOs.Product;
using App.Application.Extensions;
using App.Domain.Models.Products;
using AutoMapper;
using MediatR;

namespace App.Application.Services.ProductServices.Commands.CreateProduct
{
    public class CreateProductHandler : IRequestHandler<CreateProductDto, uint>
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IAuthenticationService _authService;

        public CreateProductHandler(IDbService dbService, IMapper mapper, IAuthenticationService authService)
        {
            _dbService = dbService;
            _mapper = mapper;
            _authService = authService;
        }

        public async Task<uint> Handle(CreateProductDto request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<CreateProductDto, Product>(request);

            product.ShopOwnerId = await _authService.GetCurrentUserId(cancellationToken);

            return await _dbService.CreateAsync<Product, uint>(product, cancellationToken);
        }
    }
}
