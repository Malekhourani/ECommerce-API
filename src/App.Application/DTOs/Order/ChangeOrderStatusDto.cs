using System;
using App.Domain.Models.Orders.OrderStatuses;

namespace App.Application.DTOs.Order
{
    public class ChangeOrderStatusDto
    {
        public Guid OrderId { get; init; }
        public OrderStatus OrderStatus { get; init; }
    }
}
