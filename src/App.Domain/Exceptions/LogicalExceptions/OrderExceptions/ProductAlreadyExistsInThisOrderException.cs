using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.OrderExceptions
{
    public class ProductAlreadyExistsInThisOrderException : BadRequestException
    {
        public ProductAlreadyExistsInThisOrderException(string message = "Product Already Exists In The Order.") : base(message)
        {

        }
    }
}
