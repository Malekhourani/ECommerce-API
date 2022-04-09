using System;
using App.Application.DTOs.Product;
using App.Application.DTOs.User;
using App.Domain.Models.Orders.OrderStatuses;

namespace App.Application.DTOs.Order
{
    public class GetUserOrderDto
    {
        public Guid Id { get; init; }
        public double Cost { get; init; }
        public DateTime CreatedAt { get; init; }
        public OrderStatus OrderStatus { get; init; }
        public GetApplicationUserInfoDto User { get; init; }
        public IEnumerable<GetGeneralProductInfoDto> Products { get; init; }
    }
}
