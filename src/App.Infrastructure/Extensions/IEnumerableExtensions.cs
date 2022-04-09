using System;

namespace App.Infrastructure.Extensions
{
    public static class IEnumerableExtensions
    {
        public static AggregateException ToAggregateException(this IEnumerable<string> errorMessages)
        {
            var exceptions = errorMessages.ToExceptionList();

            return new AggregateException(exceptions);
        }

        private static IEnumerable<Exception> ToExceptionList(this IEnumerable<string> errorMessages)
        {
            ICollection<Exception> exceptions = new List<Exception>();

            foreach (var message in errorMessages)
            {
                exceptions.Add(new Exception(message));
            }

            return exceptions;
        }
    }
}
