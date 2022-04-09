using System;
using System.ComponentModel.DataAnnotations;
using App.Application.DTOs.Product;
using App.Domain.Exceptions.LogicalExceptions.OrderExceptions;
using App.Domain.Models.Orders.OrderProducts;
using MediatR;

namespace App.Application.DTOs.Order
{
    public class CreateOrderDto : IRequest<Guid>
    {
        [Required]
        public IEnumerable<OrderProductInfoDto> Products { get; init; }

        public void CheckIfOrderHasAnyProduct()
        {
            if (! Products.Any() ) throw new OrderDoesnotHaveAnyProductException();
        }
    }
}
