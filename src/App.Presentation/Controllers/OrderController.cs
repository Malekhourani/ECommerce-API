using System;
using App.Application.Contracts;
using App.Application.DTOs.Common;
using App.Application.DTOs.Order;
using App.Domain.Models.Users;
using App.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Presentation.Controllers
{
    [Authorize(Policy = Roles.CUSTOMER_ROLE)]
    public class OrderController : BaseController<IOrderService>
    {
        public OrderController(IOrderService service) : base(service)
        {
        }

        [HttpPost]
        public async Task<Response> CreateOrder(CreateOrderDto dto, CancellationToken cancellationToken)
        {
            return await Ok<CreateOrderDto, Guid>(
                _service.CreateOrder,
                dto,
                cancellationToken
            );
        }

        [HttpGet]
        public async Task<Response> GetOrder(Guid id, CancellationToken cancellationToken)
        {
            return await Ok<Guid, GetUserOrderDto>(
                _service.GetOrder,
                id,
                cancellationToken
            );
        }

        [HttpPost]
        public async Task<Response> GetUserOrders(CancellationToken cancellationToken)
        {
            return await Ok<IEnumerable<GetUserOrderDto>>(
                _service.GetUserOrders,
                cancellationToken
            );
        }

        [HttpDelete]
        public async Task<Response> DeleteOrder(Guid id, CancellationToken cancellationToken)
        {
            return await NoContent<Guid>(
                _service.DeleteOrder,
                id,
                cancellationToken
            );
        }

        [HttpPut]
        public async Task<Response> ChangeOrderStatus(ChangeOrderStatusDto dto, CancellationToken cancellationToken)
        {
            return await NoContent<ChangeOrderStatusDto>(
                _service.ChangeOrderStatus,
                dto, 
                cancellationToken
            );
        }

        [HttpPut]
        public async Task<Response> RemoveProductFromOrder(RemoveProductFromOrderDto dto, CancellationToken cancellationToken)
        {
            return await NoContent<RemoveProductFromOrderDto>(
                _service.RemoveProductFromOrder,
                dto, 
                cancellationToken
            );
        }

        [HttpPut]
        public async Task<Response> AddNewProductToOrder(AddNewProductToOrderDto dto, CancellationToken cancellationToken)
        {
            return await NoContent<AddNewProductToOrderDto>(
                _service.AddNewProductToOrder,
                dto, 
                cancellationToken
            );
        }

        [HttpPut]
        public async Task<Response> ChangeProductQuantity(ChangeProductQuantityDto dto, CancellationToken cancellationToken)
        {
            return await NoContent<ChangeProductQuantityDto>(
                _service.ChangeProductQuantity,
                dto, 
                cancellationToken
            );
        }

        [HttpPut]
        public async Task<Response> MarkOrderAsReceived(Guid id, CancellationToken cancellationToken)
        {
            return await NoContent<Guid>(
                _service.MarkOrderAsReceived,
                id, 
                cancellationToken
            );
        }
    }
}
