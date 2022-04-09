using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.ProductExceptions
{
    public class RequriedQuantityIsNotAvailableException : BadRequestException
    {
        public RequriedQuantityIsNotAvailableException(string message = "Required Quantity is Not Available!") : base(message)
        {
            
        }
    }
}
