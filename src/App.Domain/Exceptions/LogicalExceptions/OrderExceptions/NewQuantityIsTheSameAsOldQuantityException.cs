using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.OrderExceptions
{
    public class NewQuantityIsTheSameAsOldQuantityException : BadRequestException
    {
        public NewQuantityIsTheSameAsOldQuantityException(string message = "New Quantity Is The Same As Old Quantity") : base(message)
        {
            
        }
    }
}
