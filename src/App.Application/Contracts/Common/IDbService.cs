using System;
using System.Linq.Expressions;
using App.Application.DTOs.Common;
using App.Domain.Models.Common;
using Microsoft.EntityFrameworkCore.Storage;

namespace App.Application.Contracts.Common
{
    public interface IDbService
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task<TKey> CreateAsync<TEntity, TDto, TKey>(TDto dto, CancellationToken cancellationToken)
            where TEntity : class;

        Task<object[]> CreateAsync<TEntity>(TEntity entity, CancellationToken cancellationToken)
            where TEntity : class;

        Task<object[]> CreateAsync<TEntity, TDto>(TDto dto, CancellationToken cancellationToken)
            where TEntity : class;

        Task UpdateAsync<TEntity, TDto>(object key, TDto dto, CancellationToken cancellationToken)
            where TEntity : class;

        Task UpdateAsync<TEntity>(TEntity entity, CancellationToken cancellationToken)
            where TEntity : class;

        Task DeleteAsync<TEntity>(TEntity entity, CancellationToken cancellationToken)
            where TEntity : class;

        Task DeleteAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : class;

        Task DeleteAsync<TEntity>(Expression<Func<TEntity, bool>> whereExperssion, CancellationToken cancellationToken)
            where TEntity : class;

        Task SoftDeleteAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : DeletableEntity;

        Task<TEntity> GetAsync<TEntity>(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken)
            where TEntity : class;

        IQueryable<TEntity> GetAll<TEntity>(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken)
            where TEntity : class;
            
        Task<TEntity> GetByIdAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : class;

        Task<TResult> GetByIdAsync<TEntity, TResult>(object key, CancellationToken cancellationToken)
            where TEntity : class;

        Task<IEnumerable<TDto>> GetAllAsync<TEntity, TDto>(CancellationToken cancellationToken)
            where TEntity : class;

        Task<IEnumerable<TResult>> GetAsPageAsync<TEntity, TKey, TResult, TPageDto>(TPageDto dto, Expression<Func<TEntity, bool>> condition = null, CancellationToken cancellationToken = default)
            where TEntity : class
            where TPageDto : GetPageDto;
    }
}
