using System;
using System.Linq.Expressions;
using App.Application.DTOs.Common;
using App.Domain.Models.Common;

namespace App.Application.Contracts.Common
{
    public interface IAppService
    {
        Task<Response> CreateAsync<TEntity, TDto>(TDto dto, CancellationToken cancellationToken)
            where TEntity : class;
        Task<Response> CreateAsync<TEntity, TDto, TKey>(TDto dto, CancellationToken cancellationToken)
            where TEntity : class;

        Task<Response> UpdateAsync<TEntity, TDto>(object key, TDto dto, CancellationToken cancellationToken)
            where TEntity : class;

        Task<Response> DeleteAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : class;
        
        Task<Response> DeleteAsync<TEntity>(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken)
            where TEntity : class;

        Task<Response> SoftDeleteAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : DeletableEntity;

        Task<Response> GetByIdAsync<TEntity, TResult>(object key, CancellationToken cancellationToken)
            where TEntity : class;

        Task<Response> GetAllAsync<TEntity, TDto>(CancellationToken cancellationToken)
            where TEntity : class;

        Task<Response> GetPageAsync<TEntity, TKey, TResult, TPageDto>(TPageDto dto, Expression<Func<TEntity, bool>> condition = null, CancellationToken cancellationToken = default)
            where TEntity : class
            where TPageDto : GetPageDto;
    }
}
