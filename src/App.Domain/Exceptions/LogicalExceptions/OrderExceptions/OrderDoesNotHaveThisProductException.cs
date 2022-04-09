using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.OrderExceptions
{
    public class OrderDoesNotHaveThisProductException : NotFoundException
    {
        public OrderDoesNotHaveThisProductException(string message = "You can't delete this Product, Beacuse Order Doesn't Have this It.") : base(message)
        {
        }
    }
}
