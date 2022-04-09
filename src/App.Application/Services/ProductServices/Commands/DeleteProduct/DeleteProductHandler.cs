using System;
using App.Application.Contracts.Common;
using App.Domain.Exceptions.LogicalExceptions.ProductExceptions;
using App.Domain.Models.Products;
using App.Domain.Models.Users;
using AutoMapper;
using MediatR;

namespace App.Application.Services.ProductServices.Commands.DeleteProduct
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductRequest>
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IAuthenticationService _authService;

        public DeleteProductHandler(IDbService dbService, IMapper mapper, IAuthenticationService authService)
        {
            _dbService = dbService;
            _mapper = mapper;
            _authService = authService;
        }

        public async Task<Unit> Handle(DeleteProductRequest request, CancellationToken cancellationToken)
        {
            var user = await _authService.GetCurrentUser(cancellationToken);

            var product = await _dbService.GetByIdAsync<Product>(request.Id, cancellationToken);

            var isAdmin = await _authService.IsInOneOfRoles(user, Roles.ADMIN_ROLE);

            if (!product.IsAbleToDeleteProduct(user.Id, isAdmin)) throw new OnlyAdminAndTheShopOwnerCanDeleteProductException();

            await _dbService.DeleteAsync<Product>(product, cancellationToken);

            return Unit.Value;
        }
    }
}
