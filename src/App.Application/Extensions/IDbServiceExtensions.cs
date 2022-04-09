using System;
using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using App.Domain.Exceptions.LogicalExceptions.CategoryExceptions;
using App.Domain.Models.Products.Categories;

namespace App.Application.Extensions
{
    public static class IDbServiceExtensions
    {
        public static async Task<IEnumerable<TResult>> GetAsPageAsync<TEntity, TKey, TResult>(this IDbService dbService, GetPageDto dto, CancellationToken cancellationToken)
            where TEntity : class
        {
            return await dbService.GetAsPageAsync<TEntity, TKey, TResult, GetPageDto>(dto, null, cancellationToken);
        }

        public static IQueryable<TEntity> GetAsPage<TEntity, TKey, TPageDto>(this IDbService dbService, GetPageDto dto, CancellationToken cancellationToken)
            where TEntity : class
        {
            return dbService.GetAsPage<TEntity, TKey, GetPageDto>(dto, cancellationToken);
        }

        public static async Task<TKey> CreateAsync<TEntity, TKey>(this IDbService dbService, TEntity entity, CancellationToken cancellationToken)
            where TEntity : class
        {
            var keys = await dbService.CreateAsync<TEntity>(entity, cancellationToken);

            return keys[0].CastTo<TKey>();
        }
    }
}
