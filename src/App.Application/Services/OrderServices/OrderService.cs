using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using App.Application.DTOs.Order;
using App.Domain.Models.Orders;
using App.Application.Extensions;
using TanvirArjel.EFCore.GenericRepository;
using Microsoft.EntityFrameworkCore.Storage;
using App.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using App.Domain.Models.Orders.OrderStatuses;
using App.Domain.Exceptions.LogicalExceptions.OrderExceptions;

namespace App.Application.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private readonly IDbService _dbService;
        private readonly IAuthenticationService _authService;
        private readonly IRepository _repo;
        private readonly IOrderProductService _orderProductService;
        private readonly IProductService _productService;

        public OrderService(IDbService dbService, IAuthenticationService authService, IRepository repo, IOrderProductService orderProductService, IProductService productService)
        {
            _dbService = dbService;
            _authService = authService;
            _repo = repo;
            _orderProductService = orderProductService;
            _productService = productService;
        }

        public async Task<Guid> CreateOrder(CreateOrderDto dto, CancellationToken cancellationToken)
        {
            dto.CheckIfOrderHasAnyProduct();

            using var transaction = await _repo.BeginTransactionAsync(cancellationToken: cancellationToken);


            var userId = await _authService.GetCurrentUserId(cancellationToken);

            var products = await _productService.GetProducts(dto.Products.SelectProductIds(), cancellationToken);

            var orderCost = products.CalculateOrderCost(dto.Products);

            var order = Order.Factory(userId, orderCost);

            var orderId = await _repo.InsertAsync<Order, Guid>(order, cancellationToken);


            await _orderProductService.LinkProductsWithOrder(orderId, dto.Products, products, cancellationToken);


            await transaction.CommitAsync(cancellationToken);

            return orderId;
        }

        public Task<GetUserOrderDto> GetOrder(Guid id, CancellationToken cancellationToken)
        {
            return _dbService.GetByIdAsync<Order, GetUserOrderDto>(id, cancellationToken);
        }

        public Task DeleteOrder(Guid id, CancellationToken cancellationToken)
        {
            return _dbService.SoftDeleteAsync<Order>(id, cancellationToken);
        }

        public async Task<IEnumerable<GetUserOrderDto>> GetUserOrders(GetPageDto dto, CancellationToken cancellationToken)
        {
            var userId = await _authService.GetCurrentUserId(cancellationToken);

            return await _dbService.GetAsPageAsync<Order, Guid, GetUserOrderDto, GetPageDto>(dto,
            order => order.ApplicationUserId == userId,
            cancellationToken);
        }
        
        public async Task ChangeOrderStatus(ChangeOrderStatusDto request, CancellationToken cancellationToken)
        {
            var order = await _dbService.GetByIdAsync<Order>(request.OrderId, cancellationToken);

            order.ChangeOrderStatus(request.OrderStatus);

            await _dbService.UpdateAsync<Order>(order, cancellationToken);
        }

        public async Task RemoveProductFromOrder(RemoveProductFromOrderDto request, CancellationToken cancellationToken)
        {
            using var transaction = await _dbService.BeginTransactionAsync();

            var pivot = await _orderProductService.GetCorrspondOrderProductEntity(request.OrderId, request.ProductId, cancellationToken);

            if(pivot.Order.OrderStatus == OrderStatus.Shipped) throw new CanNotDeleteShippedOrdersException();

            pivot.Order.DecreaseOrderCost(pivot.Quantity, pivot.Product.Price);

            await _orderProductService.RemoveProductFromOrder(pivot, cancellationToken);

            await transaction.CommitAsync(cancellationToken);
        }

        public async Task AddNewProductToOrder(AddNewProductToOrderDto request, CancellationToken cancellationToken)
        {
            using var transaction = await _repo.BeginTransactionAsync(cancellationToken: cancellationToken);


            await _orderProductService.CheckIfProductAlreadyExistsInOrder(request.OrderId, request.NewProduct.ProductId, cancellationToken);

            var product = await _productService.GetProduct(request.NewProduct.ProductId, cancellationToken);

            product.ValidateNewProductsQuantity(request.NewProduct.Quantity);


            var order = await _dbService.GetByIdAsync<Order>(request.OrderId, cancellationToken);

            order.IncreaseOrderCost(newQuantity: request.NewProduct.Quantity, price: product.Price);

            await _dbService.UpdateAsync<Order>(order, cancellationToken);


            await _orderProductService.LinkProductWithOrder(request.OrderId, request.NewProduct.ProductId, request.NewProduct.Quantity, product.Price, cancellationToken);


            await transaction!.CommitAsync(cancellationToken);
        }


        public async Task ChangeProductQuantity(ChangeProductQuantityDto request, CancellationToken cancellationToken)
        {
            using var transaction = await _repo.BeginTransactionAsync(cancellationToken: cancellationToken);


            var pivot = await _orderProductService.GetCorrspondOrderProductEntity(request.OrderId, request.Product.ProductId, cancellationToken);

            await _orderProductService.ChangeProductQuantity(pivot, request.Product.Quantity, cancellationToken);


            await transaction!.CommitAsync(cancellationToken);
        }
    }
}
