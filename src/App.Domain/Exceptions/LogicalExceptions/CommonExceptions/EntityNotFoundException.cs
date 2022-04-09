using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.TechnicalExceptions
{
    public class EntityNotFoundException : NotFoundException
    {
        public EntityNotFoundException(string message = "Entity Not Found") : base(message)
        {
            
        }
    }
}
