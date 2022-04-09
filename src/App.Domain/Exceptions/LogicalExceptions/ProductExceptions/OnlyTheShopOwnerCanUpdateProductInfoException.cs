using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.ProductExceptions
{
    public class OnlyTheShopOwnerCanUpdateProductInfoException : AuthorizationException 
    {
        public OnlyTheShopOwnerCanUpdateProductInfoException(string message = "Only The Shop Owner Can Update Product Info.")
            : base(message)
        {
            
        }
    }
}
