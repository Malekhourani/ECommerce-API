using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.ProductExceptions
{
    public class ProductQuantityMustBeMoreThanZeroException : BadRequestException
    {
        public ProductQuantityMustBeMoreThanZeroException(string message = "Product Quantity Must Be More Than Zero") : base(message)
        {
        }
    }
}
