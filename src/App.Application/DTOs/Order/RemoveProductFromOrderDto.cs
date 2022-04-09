using System;

namespace App.Application.DTOs.Order
{
    public class RemoveProductFromOrderDto
    {
        public Guid OrderId { get; set; }
        public uint ProductId { get; set; }
    }
}
