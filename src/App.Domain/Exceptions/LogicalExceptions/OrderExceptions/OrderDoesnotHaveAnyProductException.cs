using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.OrderExceptions
{
    public class OrderDoesnotHaveAnyProductException : BadRequestException
    {
        public OrderDoesnotHaveAnyProductException(string message = "Order Does Not Have Any Product.") : base(message)
        {
            
        }
    }
}
