using System;
using App.Application.Extensions;
using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using App.Domain.Exceptions.TechnicalExceptions;
using App.Domain.Models.Common;
using System.Linq.Expressions;
using App.Domain.Exceptions.LogicalExceptions;
using App.Domain.Exceptions.LogicalExceptions.User;

namespace App.Infrastructure.Services.Common
{
    public class AppService : IAppService
    {
        private readonly IDbService _dbService;

        public AppService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<Response> CreateAsync<TEntity, TDto, TKey>(TDto dto, CancellationToken cancellationToken)
            where TEntity : class
        {
            try
            {
                var data = await _dbService.CreateAsync<TEntity, TDto, TKey>(dto, cancellationToken);

                return Response.Ok(data);
            }
            catch(UserDidnotLoginException)
            {
                return Response.Unauthorized();
            }
            catch(EntityNotFoundException)
            {
                return Response.NotFound();
            }
            catch(LogicalException ex)
            {
                return Response.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return Response.Error();
            }
        }


        public async Task<Response> CreateAsync<TEntity, TDto>(TDto dto, CancellationToken cancellationToken)
            where TEntity : class
        {
            try
            {
                await _dbService.CreateAsync<TEntity, TDto>(dto, cancellationToken);

                return Response.NoContent();
            }
            catch(UserDidnotLoginException)
            {
                return Response.Unauthorized();
            }
            catch(EntityNotFoundException)
            {
                return Response.NotFound();
            }
            catch(LogicalException ex)
            {
                return Response.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return Response.Error();
            }
        }

        public async Task<Response> UpdateAsync<TEntity, TDto>(object key, TDto dto, CancellationToken cancellationToken)
            where TEntity : class
        {
            try
            {
                await _dbService.UpdateAsync<TEntity, TDto>(key, dto, cancellationToken);

                return Response.NoContent();
            }
            catch(UserDidnotLoginException)
            {
                return Response.Unauthorized();
            }
            catch(EntityNotFoundException)
            {
                return Response.NotFound();
            }
            catch(LogicalException ex)
            {
                return Response.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return Response.Error();
            }
        }



        public async Task<Response> DeleteAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : class
        { 
            try
            {
                await _dbService.DeleteAsync<TEntity>(key, cancellationToken);

                return Response.NoContent();
            }
            catch(UserDidnotLoginException)
            {
                return Response.Unauthorized();
            }
            catch(EntityNotFoundException)
            {
                return Response.NotFound();
            }
            catch(LogicalException ex)
            {
                return Response.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return Response.Error();
            }
        }

        public async Task<Response> DeleteAsync<TEntity>(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken)
            where TEntity : class
        {
            try
            {
                await _dbService.DeleteAsync<TEntity>(condition, cancellationToken);

                return Response.NoContent();
            }
            catch(UserDidnotLoginException)
            {
                return Response.Unauthorized();
            }
            catch(EntityNotFoundException)
            {
                return Response.NotFound();
            }
            catch(LogicalException ex)
            {
                return Response.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return Response.Error();
            }
        }

        public async Task<Response> SoftDeleteAsync<TEntity>(object key, CancellationToken cancellationToken)
            where TEntity : DeletableEntity
        { 
            try
            {
                await _dbService.SoftDeleteAsync<TEntity>(key, cancellationToken);

                return Response.NoContent();
            }
            catch(UserDidnotLoginException)
            {
                return Response.Unauthorized();
            }
            catch(EntityNotFoundException)
            {
                return Response.NotFound();
            }
            catch(LogicalException ex)
            {
                return Response.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return Response.Error();
            }
        }

        public async Task<Response> GetByIdAsync<TEntity, TResult>(object key, CancellationToken cancellationToken) 
            where TEntity : class
        {
            try
            {
                var data = await _dbService.GetByIdAsync<TEntity, TResult>(key, cancellationToken);

                return Response.Ok(data);
            }
            catch(UserDidnotLoginException)
            {
                return Response.Unauthorized();
            }
            catch(EntityNotFoundException)
            {
                return Response.NotFound();
            }
            catch(LogicalException ex)
            {
                return Response.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return Response.Error();
            }
        }

        public async Task<Response> GetAllAsync<TEntity, TDto>(CancellationToken cancellationToken) 
            where TEntity : class
        {
            try
            {
                var data = await _dbService.GetAllAsync<TEntity, TDto>(cancellationToken);

                return Response.Ok(data);
            }
            catch(UserDidnotLoginException)
            {
                return Response.Unauthorized();
            }
            catch(EntityNotFoundException)
            {
                return Response.NotFound();
            }
            catch(LogicalException ex)
            {
                return Response.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return Response.Error();
            }
        }

        public async Task<Response> GetPageAsync<TEntity, TKey, TResult, TPageDto>(TPageDto dto, Expression<Func<TEntity, bool>> condition = null, CancellationToken cancellationToken = default) 
            where TEntity : class
            where TPageDto : GetPageDto
        {
            try
            {
                var data = await _dbService.GetAsPageAsync<TEntity, TKey, TResult, TPageDto>(dto, condition, cancellationToken);

                return Response.Ok(data);
            }
            catch(UserDidnotLoginException)
            {
                return Response.Unauthorized();
            }
            catch(EntityNotFoundException)
            {
                return Response.NotFound();
            }
            catch(LogicalException ex)
            {
                return Response.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return Response.Error();
            }
        }
    }
}
