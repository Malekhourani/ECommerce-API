using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.ProductExceptions;

public class ProductPriceCanNotBeLessThanZeroException : BadRequestException
{
    public ProductPriceCanNotBeLessThanZeroException(string message = "Product\'s Price Can Not Be Less Than Zero.") : base(message)
    {   
    }
}
