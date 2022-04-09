using System;
using System.Linq.Expressions;

namespace App.Infrastructure.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TEntity> WhereConditionIsNotNull<TEntity>(this IQueryable<TEntity> queryable, Expression<Func<TEntity, bool>> condition)
            where TEntity : class
        {
            return condition is null ? queryable : queryable.Where(condition);
        }
    }
}
