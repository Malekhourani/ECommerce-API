using App.Application.DTOs.Common;
using App.Application.DTOs.Order;

namespace App.Application.Contracts
{
    public interface IOrderService
    {
        Task<Guid> CreateOrder(CreateOrderDto dto, CancellationToken cancellationToken);

        Task<GetUserOrderDto> GetOrder(Guid id, CancellationToken cancellationToken);

        Task DeleteOrder(Guid id, CancellationToken cancellationToken);

        Task<IEnumerable<GetUserOrderDto>> GetUserOrders(CancellationToken cancellationToken);

        Task ChangeOrderStatus(ChangeOrderStatusDto dto, CancellationToken cancellationToken);

        Task MarkOrderAsReceived(Guid id, CancellationToken cancellationToken);

        Task RemoveProductFromOrder(RemoveProductFromOrderDto request, CancellationToken cancellationToken);

        Task AddNewProductToOrder(AddNewProductToOrderDto request, CancellationToken cancellationToken);

        Task ChangeProductQuantity(ChangeProductQuantityDto request, CancellationToken cancellationToken);
    }
}
