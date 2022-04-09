using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.CategoryExceptions
{
    public class CategoryWithTheSameNameAlreadyExistsException : BadRequestException
    {
        public CategoryWithTheSameNameAlreadyExistsException(string message = "Category With The Same Name Already Exists.") : base(message)
        {
            
        }
    }
}
