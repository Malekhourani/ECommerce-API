using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.ProductExceptions
{
    public class OnlyAdminAndTheShopOwnerCanDeleteProductException : AuthorizationException
    {
        public OnlyAdminAndTheShopOwnerCanDeleteProductException(string message = "Only Admin And The Shop Owner Can Delete Product")
            : base(message)
        {
            
        }
    }
}
