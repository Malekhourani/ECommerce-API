using System;
using App.Application.DTOs.Order;
using App.Domain.Models.Orders;
using AutoMapper;

namespace App.Infrastructure.Mappers.OrderMapper
{
    public class OrderMapper : Profile
    {
        public OrderMapper()
        {
            CreateMap<ChangeOrderStatusDto, Order>()
                .ForMember(order => order.Id, opt => opt.MapFrom(dto => dto.OrderId))
                .ForMember(order => order.OrderStatus, opt => opt.MapFrom(dto => dto.OrderStatus));
        }
    }
}
