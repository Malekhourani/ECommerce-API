using System;

namespace App.Domain.Exceptions.LogicalExceptions
{
    public class LogicalException : Exception
    {
        public LogicalException(string message) : base(message)
        {
            
        }
    }
}
