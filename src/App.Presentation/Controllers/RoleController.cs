using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using App.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Presentation.Controllers
{
    public class RoleController : BaseController<IRoleService>
    {
        public RoleController(IRoleService service) : base(service)
        {
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<Response> GetRoles(CancellationToken cancellationToken)
        {
            return await Ok(
                _service.GetRoles,
                cancellationToken
            );
        }
    }
}
