using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.OrderExceptions;

public class OrderAlreadyHasThisStatusException : BadRequestException
{
    public OrderAlreadyHasThisStatusException(string status) : base($"Order Already {status}!")
    {
    }
}