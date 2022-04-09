using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;
using App.Domain.Exceptions.TechnicalExceptions;

namespace App.Domain.Exceptions.LogicalExceptions.RoleExceptions
{
    public class RoleNotFoundException : NotFoundException
    {
        public RoleNotFoundException(string message = "Role Not Found") : base(message)
        {
            
        }
    }
}
