using System;
using App.Application.DTOs.Product;
using App.Domain.Models.Orders.OrderProducts;
using App.Domain.Models.Products;

namespace App.Application.Contracts
{
    public interface IOrderProductService
    {
        Task LinkProductWithOrder(Guid orderId, uint productId, uint quantity, double price, CancellationToken cancellationToken);
        Task LinkProductsWithOrder(Guid orderId, IEnumerable<OrderProductInfoDto> requestedProducts, IEnumerable<Product> products, CancellationToken cancellationToken);
        Task RemoveProductFromOrder(OrderProduct pivot, CancellationToken cancellationToken);
        Task CheckIfProductAlreadyExistsInOrder(Guid orderId, uint productId, CancellationToken cancellationToken);
        Task<OrderProduct> GetCorrspondOrderProductEntity(Guid orderId, uint productId, CancellationToken cancellationToken);
        Task ChangeProductQuantity(OrderProduct pivot, uint newQuantity, CancellationToken cancellationToken);
    }
}
