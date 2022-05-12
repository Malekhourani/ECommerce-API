using System;
using App.Application.DTOs.Order;
using App.Application.DTOs.Product;
using App.Domain.Models.Orders;
using App.Domain.Models.Orders.OrderProducts;
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

            CreateMap<Order, GetUserOrderDto>()
                .ForPath(dto => dto.User.Id, opt=>opt.MapFrom(order => order.ApplicationUserId))
                .ForPath(dto => dto.User.Name, opt=>opt.MapFrom(order => order.ApplicationUser.UserName))
                .ForPath(dto => dto.Products, opt=>opt.MapFrom(order => order.OrderProducts));

            CreateMap<OrderProduct, GetGeneralProductInfoDto>()
                .ForMember(dto => dto.Id, opt =>opt.MapFrom(src => src.ProductId))
                .ForMember(dto => dto.Name, opt =>opt.MapFrom(src => src.Product.Name))
                .ForMember(dto => dto.Price, opt =>opt.MapFrom(src => src.Product.Price));
        }
    }
}
