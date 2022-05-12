using System;
using System.ComponentModel.DataAnnotations;
using App.Application.DTOs.Product;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;
using App.Domain.Exceptions.LogicalExceptions.OrderExceptions;
using App.Domain.Models.Orders.OrderProducts;
using MediatR;

namespace App.Application.DTOs.Order
{
    public class CreateOrderDto : IRequest<Guid>
    {
        [Required]
        public IEnumerable<OrderProductInfoDto> Products { get; init; }

        public void Validate()
        {
            CheckIfOrderHasAnyProduct();

            CheckIfOrderHasTheSameProductTwoice();
        }

        public void CheckIfOrderHasAnyProduct()
        {
            if (! Products.Any() ) throw new OrderDoesnotHaveAnyProductException();
        }

        public void CheckIfOrderHasTheSameProductTwoice()
        {
            var numberOfUniqueProducts = Products.Select(p => p.ProductId).Distinct().Count();

            var numberOfReceivedProducts = Products.Count();

            if(numberOfReceivedProducts != numberOfUniqueProducts) throw new BadRequestException("you can't add the same products twoice to the same order");
        }
    }
}
