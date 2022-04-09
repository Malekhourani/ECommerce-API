using System;

namespace App.Application.Extensions
{
    public static class ObjectExtensions
    {
        public static TKey ExtractId<TEntity, TKey>(this object[] keys)
        {
            // return (TKey) attribute?
            //                 .GetType()?
            //                 .GetProperty("Id")?
            //                 .GetValue(attribute);

            return keys[0].CastTo<TKey>();
        }

        public static int ExtractId<TEntity>(this object[] entity)
        {
            return entity.ExtractId<TEntity, int>();
        }

        public static T CastTo<T>(this object value)
        {
            var castedValue = (T) value;

            return castedValue;
        }
    }
}
