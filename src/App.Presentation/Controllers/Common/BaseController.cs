using App.Application.DTOs.Common;
using App.Domain.Exceptions.LogicalExceptions;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CustomeResponse = App.Application.DTOs.Common.Response;

namespace App.Presentation.Controllers.Common
{
    [ApiController]
    [Route("dotnet/Ecommerce/api/[controller]/[action]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public abstract class BaseController<TService> : ControllerBase
    {
        protected readonly TService _service;
        protected BaseController(TService service)
        {
            _service = service;
        }

        protected async Task<CustomeResponse> NoContent(Func<CancellationToken, Task> task, CancellationToken cancellationToken)
        {
            try
            {
                await task(cancellationToken);

                return CustomeResponse.NoContent();
            }
            catch (AuthenticationException)
            {
                return CustomeResponse.Unauthorized();
            }
            catch (AuthorizationException ex)
            {
                return CustomeResponse.Forbidden(ex.Message);
            }
            catch (NotFoundException ex)
            {
                return CustomeResponse.NotFound(ex.Message);
            }
            catch (BadRequestException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (LogicalException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return CustomeResponse.Error();
            }
        }

        protected async Task<CustomeResponse> NoContent<TParam>(Func<TParam, CancellationToken, Task> task, TParam param, CancellationToken cancellationToken)
        {
            try
            {
                await task(param, cancellationToken);

                return CustomeResponse.NoContent();
            }
            catch (AuthenticationException)
            {
                return CustomeResponse.Unauthorized();
            }
            catch (AuthorizationException ex)
            {
                return CustomeResponse.Forbidden(ex.Message);
            }
            catch (NotFoundException ex)
            {
                return CustomeResponse.NotFound(ex.Message);
            }
            catch (BadRequestException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (LogicalException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return CustomeResponse.Error();
            }
        }

        protected async Task<CustomeResponse> Ok<TParam, TResult>(Func<TParam, CancellationToken, Task<TResult>> task, TParam param, CancellationToken cancellationToken)
        {
            try
            {
                var data = await task(param, cancellationToken);

                return CustomeResponse.Ok(data);
            }
            catch (AuthenticationException)
            {
                return CustomeResponse.Unauthorized();
            }
            catch (AuthorizationException ex)
            {
                return CustomeResponse.Forbidden(ex.Message);
            }
            catch (NotFoundException ex)
            {
                return CustomeResponse.NotFound(ex.Message);
            }
            catch (BadRequestException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (LogicalException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                if (ex.InnerException is not null) message += ex.InnerException.Message;

                return CustomeResponse.Error(message);
            }
        }

        protected async Task<CustomeResponse> Ok<TParam1, TParam2, TParam3, TResult>(Func<TParam1, TParam2, TParam3, CancellationToken, Task<TResult>> task, TParam1 param1, TParam2 param2, TParam3 param3, CancellationToken cancellationToken)
        {
            try
            {
                var data = await task(param1, param2, param3, cancellationToken);

                return CustomeResponse.Ok(data);
            }
            catch (AuthenticationException)
            {
                return CustomeResponse.Unauthorized();
            }
            catch (AuthorizationException ex)
            {
                return CustomeResponse.Forbidden(ex.Message);
            }
            catch (NotFoundException ex)
            {
                return CustomeResponse.NotFound(ex.Message);
            }
            catch (BadRequestException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (LogicalException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                if (ex.InnerException is not null) message += ex.InnerException.Message;

                return CustomeResponse.Error(message);
            }
        }

        protected async Task<CustomeResponse> Ok<TResult>(Func<CancellationToken, Task<TResult>> task, CancellationToken cancellationToken)
        {
            try
            {
                var data = await task(cancellationToken);

                return CustomeResponse.Ok(data);
            }
            catch (AuthenticationException)
            {
                return CustomeResponse.Unauthorized();
            }
            catch (AuthorizationException ex)
            {
                return CustomeResponse.Forbidden(ex.Message);
            }
            catch (NotFoundException ex)
            {
                return CustomeResponse.NotFound(ex.Message);
            }
            catch (BadRequestException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (LogicalException ex)
            {
                return CustomeResponse.BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return CustomeResponse.Error(ex.Message);
            }
        }
    }
}
