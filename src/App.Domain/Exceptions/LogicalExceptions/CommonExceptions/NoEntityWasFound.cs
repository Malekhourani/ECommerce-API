using System;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;

namespace App.Domain.Exceptions.TechnicalExceptions
{
    public class NoEntityWasFound : NotFoundException
    {
        public NoEntityWasFound(string message = "No Entity was found!") 
                : base(message)
        {
        }
    }
}
