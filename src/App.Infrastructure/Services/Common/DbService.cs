using App.Application.Extensions;
using App.Domain.Exceptions.TechnicalExceptions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TanvirArjel.EFCore.GenericRepository;
using System.Linq.Expressions;
using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using Microsoft.EntityFrameworkCore.Storage;
using App.Domain.Models.Common;
using App.Infrastructure.Extensions;
using App.Services.DynamicExpression;

namespace App.Infrastructure.Services.Common
{
    public class DbService : IDbService
    {
        private readonly IMapper _mapper;
        private readonly IRepository _repo;

        public DbService(IMapper mapper, IRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return _repo.BeginTransactionAsync();
        }

        public async Task<TKey> CreateAsync<TEntity, TDto, TKey>(TDto dto, CancellationToken cancellationToken)
            where TEntity : class
        {
            var entityId = await CreateAsync<TEntity, TDto>(dto, cancellationToken);

            return entityId.ExtractId<TEntity, TKey>();
        }

        public async Task<object[]> CreateAsync<TEntity, TDto>(TDto dto, CancellationToken cancellationToken)
            where TEntity : class
        {
            var mappedObject = _mapper.Map<TDto, TEntity>(dto);

            var entityId = await CreateAsync(mappedObject, cancellationToken);

            return entityId;
        }

        public async Task<object[]> CreateAsync<TEntity>(TEntity entity, CancellationToken cancellationToken)
            where TEntity : class
        {
            return await _repo.InsertAsync(entity, cancellationToken);
        }

        public async Task UpdateAsync<TEntity, TDto>(object key, TDto dto, CancellationToken cancellationToken)
            where TEntity : class
        {
            var entity = await GetByIdAsync<TEntity>(key, cancellationToken);

            var mappedObject = _mapper.Map<TDto, TEntity>(dto, entity);

            await UpdateAsync(mappedObject, cancellationToken);
        }

        public async Task UpdateAsync<TEntity>(TEntity entity, CancellationToken cancellationToken)
            where TEntity : class
        {
            await _repo.UpdateAsync<TEntity>(entity, cancellationToken);
        }

        public async Task DeleteAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : class
        {
            var entity = await GetByIdAsync<TEntity>(key, cancellationToken);

            await DeleteAsync<TEntity>(entity, cancellationToken);
        }

        public async Task DeleteAsync<TEntity>(Expression<Func<TEntity, bool>> whereExperssion, CancellationToken cancellationToken)
            where TEntity : class
        {
            var entities = GetByExpression<TEntity>(whereExperssion, cancellationToken);

            if (entities is null) throw new NoEntityWasFound();

            await _repo.DeleteAsync(entities);
        }

        public async Task DeleteAsync<TEntity>(TEntity entity, CancellationToken cancellationToken)
            where TEntity : class
        {
            await _repo.DeleteAsync<TEntity>(entity, cancellationToken);
        }

        public async Task SoftDeleteAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : DeletableEntity
        {
            var entity = await GetByIdAsync<TEntity>(key, cancellationToken);

            entity.IsDeleted = true;

            await UpdateAsync<TEntity>(entity, cancellationToken);
        }

        public async Task<TEntity> GetAsync<TEntity>(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken)
            where TEntity : class
        {
            var entity = await _repo.GetAsync<TEntity>(condition, cancellationToken);

            if (entity is null) throw new EntityNotFoundException($"{typeof(TEntity).Name} Was Not Found");

            return entity;
        }

        public IQueryable<TEntity> GetAll<TEntity>(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken)
            where TEntity : class
        {
            return GetByExpression<TEntity>(condition, cancellationToken);
        }

        private IQueryable<TEntity> GetByExpression<TEntity>(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken)
            where TEntity : class
        {
            return _repo.GetQueryable<TEntity>()
                                        .Where(condition);
        }


        public async Task<TEntity> GetByIdAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : class
        {
            var entity = await _repo.GetByIdAsync<TEntity>(key, cancellationToken);

            if (entity is null) throw new EntityNotFoundException($"{nameof(TEntity)} Not Found");

            return entity;
        }

        public async Task<TResult> GetByIdAsync<TEntity, TResult>(object key, CancellationToken cancellationToken)
            where TEntity : class
        {
            var entity = await GetByIdAsync<TEntity>(key, cancellationToken);

            var mappedEntity = _mapper.Map<TEntity, TResult>(entity);

            return mappedEntity;
        }

        public async Task<IEnumerable<TDto>> GetAllAsync<TEntity, TDto>(CancellationToken cancellationToken)
            where TEntity : class
        {
            var entities = _repo.GetQueryable<TEntity>();

            if (entities is null) throw new NoEntityWasFound();

            var mappedObjects = await _mapper.ProjectTo<TDto>(entities)
                                                .ToListAsync(cancellationToken);

            return mappedObjects;
        }

        public async Task<IEnumerable<TResult>> GetAsPageAsync<TEntity, TKey, TResult, TPageDto>(TPageDto dto, Expression<Func<TEntity, bool>> condition = null, CancellationToken cancellationToken = default)
            where TEntity : class
            where TPageDto : GetPageDto
        {
            var entities = GetAsPage<TEntity, TKey, TPageDto>(dto, condition, cancellationToken);

            var mappedObjects = await _mapper.ProjectTo<TResult>(entities)
                                                .ToListAsync(cancellationToken);

            return mappedObjects;
        }

        private IQueryable<TEntity> GetAsPage<TEntity, TKey, TPageDto>(TPageDto dto, Expression<Func<TEntity, bool>> condition = null, CancellationToken cancellationToken = default)
            where TEntity : class
            where TPageDto : GetPageDto
        {
            var expression = ExpressionHelper.BuildOrderByQueryDynamically<TEntity, TKey>();

            var entities = _repo.GetQueryable<TEntity>()
                                    .WhereConditionIsNotNull(condition)
                                    .OrderBy(expression)
                                    .Skip((dto.PageId - 1) * dto.PageSize)
                                    .Take(dto.PageSize);

            if (entities is null) throw new NoEntityWasFound($"No {nameof(TEntity)}s Was Found");

            return entities;
        }
    }
}