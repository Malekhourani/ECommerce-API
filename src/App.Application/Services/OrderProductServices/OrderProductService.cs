using System;
using App.Application.Contracts;
using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using App.Application.DTOs.Product;
using App.Domain.Exceptions.LogicalExceptions.OrderExceptions;
using App.Domain.Models.Orders.OrderProducts;
using App.Domain.Models.Orders.OrderStatuses;
using App.Domain.Models.Products;
using Microsoft.EntityFrameworkCore;
using TanvirArjel.EFCore.GenericRepository;

namespace App.Application.Services.OrderProductServices
{
    public class OrderProductService : IOrderProductService
    {
        private readonly IRepository _repo;
        private readonly IDbService _dbService;

        public OrderProductService(IRepository repo, IDbService dbService)
        {
            _repo = repo;
            _dbService = dbService;
        }

        public async Task RemoveProductFromOrder(OrderProduct pivot, CancellationToken cancellationToken)
        {
            await _dbService.DeleteAsync<OrderProduct>(pivot, cancellationToken);
        }

        public async Task LinkProductsWithOrder(Guid orderId, IEnumerable<OrderProductInfoDto> requestedProducts, IEnumerable<Product> products, CancellationToken cancellationToken)
        {
            var orderedProductsDto = requestedProducts.OrderBy(x => x.ProductId).ToArray();

            var orderedProductEntity = products.OrderBy(x => x.Id).ToArray();

            ICollection<OrderProduct> orderProducts = new List<OrderProduct>();

            for (int i = 0; i < orderedProductsDto.Length; i++)
            {

                var order = OrderProduct.Factory(orderId,
                                 orderedProductEntity[i].Id,
                                    orderedProductsDto[i].Quantity,
                                     orderedProductEntity[i].Price
                                     );

                orderProducts.Add(order);
            }

            await _repo.InsertAsync<OrderProduct>(orderProducts, cancellationToken);
        }

        public async Task LinkProductWithOrder(Guid orderId, uint productId, uint quantity, double price, CancellationToken cancellationToken)
        {
            var pivot = OrderProduct.Factory(orderId, productId, quantity, price);

            await _dbService.CreateAsync<OrderProduct>(pivot, cancellationToken);
        }

        public async Task CheckIfProductAlreadyExistsInOrder(Guid orderId, uint productId, CancellationToken cancellationToken)
        {
            var pivot = await _repo.GetAsync<OrderProduct>(pivot => pivot.OrderId == orderId && pivot.ProductId == productId, cancellationToken);

            if (pivot is not null) throw new ProductAlreadyExistsInThisOrderException();
        }

        public async Task<OrderProduct> GetCorrspondOrderProductEntity(Guid orderId, uint productId, CancellationToken cancellationToken)
        {
            var pivot = await _repo.GetAsync<OrderProduct>(pivot => pivot.OrderId == orderId && pivot.ProductId == productId, cancellationToken);

            if (pivot is null) throw new OrderDoesNotHaveThisProductException();

            return pivot;
        }

        public async Task ChangeProductQuantity(OrderProduct pivot, uint newQuantity, CancellationToken cancellationToken)
        {
            pivot.ChangeProductQuantity(newQuantity);

            await _dbService.UpdateAsync<OrderProduct>(pivot, cancellationToken);
        }

        public async Task<IEnumerable<GetMostPaidProductDto>> GetMostPaidProducts(GetPageDto dto, CancellationToken cancellationToken)
        {
            /**
            * Select OrderProducts.ProductId as Id, Product.Name, Sum(OrderProduct.Quantity) as PaidQuantity
            * From OrderProducts
            * INNER JOIN Orders
            *   ON Orders.Id = OrderProduct.OrderId
            * INNER JOIN Products
            *   ON Products.Id = OrderProduct.ProductId
            * WHERE Order.IsDeleted == FALSE
            * GROUP BY OrderProducts.ProductId
            * ORDER BY PaidQuantity
            * OFFSET (PageSize * (PageId - 1)) 
            * LIMIT PageSize
            */

            var mostPaidProducts = await _repo.GetQueryable<OrderProduct>()
                                                .Include(orderProduct => orderProduct.Order)
                                                .ThenInclude(orderProduct => orderProduct.ApplicationUser)
                                                .Include(orderProduct => orderProduct.Product)
                                                .Where(orderProduct => orderProduct.Order.OrderStatus == OrderStatus.Shipped)
                                                .GroupBy(orderProduct => orderProduct.ProductId,
                                                            (productId, orderProducts) => new GetMostPaidProductDto
                                                            {
                                                                Id = productId,
                                                                Name = orderProducts.Where(orderProduct => orderProduct.ProductId == productId)
                                                                                    .Select(orderProduct => orderProduct.Product.Name)
                                                                                    .First(),
                                                                PaidQuantity = (uint)orderProducts.Select(orderProduct => orderProduct.Quantity)
                                                                                                    .Count()
                                                            })
                                                .OrderBy(orderProduct => orderProduct.PaidQuantity)
                                                .Skip((dto.PageId - 1) * dto.PageSize)
                                                .Take(dto.PageSize)
                                                .ToListAsync(cancellationToken);

            return mostPaidProducts;
        }
    }
}
