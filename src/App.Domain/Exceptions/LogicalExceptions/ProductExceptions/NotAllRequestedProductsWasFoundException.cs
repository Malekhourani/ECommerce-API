using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.ProductExceptions
{
    public class NotAllRequestedProductsWasFoundException : NotFoundException
    {
        public NotAllRequestedProductsWasFoundException(string message = "Not All Requested Products Was Found.\nMaybe some of it was Deleted or it\'s Not Available in the Present.")
            : base(message)
        {
            
        }
    }
}
