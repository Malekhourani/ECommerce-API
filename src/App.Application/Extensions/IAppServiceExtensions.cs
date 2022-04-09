using System;
using System.Linq.Expressions;
using App.Application.Contracts.Common;
using App.Application.DTOs.Common;

namespace App.Application.Extensions
{
    public static class IAppServiceExtensions
    {
        public static async Task<Response> GetPageAsync<TEntity, TKey, TResult>(this IAppService appService, GetPageDto dto, CancellationToken cancellationToken)
            where TEntity : class
        {
            return await appService.GetPageAsync<TEntity, TKey, TResult>(dto, null, cancellationToken);
        }

        public static async Task<Response> GetPageAsync<TEntity, TKey, TResult>(this IAppService appService, GetPageDto dto, Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken)
            where TEntity : class
        {
            return await appService.GetPageAsync<TEntity, TKey, TResult, GetPageDto>(dto, condition, cancellationToken);
        }
    }
}
