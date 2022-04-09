using System;
using System.Linq.Expressions;

namespace App.Services.DynamicExpression
{
    public static class ExpressionHelper
    {
        public static Expression<Func<TEntity, TKey>> BuildOrderByQueryDynamically<TEntity, TKey>()
            where TEntity : class
        {
            var genericParameterType = typeof(TEntity);

            var lambdaParameter = Expression.Parameter(genericParameterType, "entity");

            var getIdProperty = Expression.MakeMemberAccess(lambdaParameter, genericParameterType.GetProperty("Id")!);

            var expression = Expression.Lambda<Func<TEntity, TKey>>(getIdProperty, lambdaParameter);

            return expression;
        }
    }
}
