using System;

namespace App.Domain.Exceptions.LogicalExceptions.CommonExceptions
{
    public class NotFoundException : LogicalException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
