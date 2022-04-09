using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.OrderExceptions;

public class CanNotDeleteShippedOrdersException : BadRequestException
{
    public CanNotDeleteShippedOrdersException(string message = "Can Not Delete Shipped Order") : base(message)
    {
    }
}
