using System;

namespace App.Domain.Exceptions.TechnicalExceptions
{
    public class TechnicalException : Exception
    {
        public TechnicalException(string message) : base(message)
        {
            
        }
    }
}
