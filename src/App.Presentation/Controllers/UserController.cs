using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using App.Application.DTOs.User;
using App.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Presentation.Controllers
{
    [AllowAnonymous]
    public class UserController : BaseController<IAuthenticationService>
    {
        public UserController(IAuthenticationService service) : base(service)
        {
        }

        [HttpPost]
        public async Task<Response> RegisterCustomer(CreateUserDto dto, CancellationToken cancellationToken)
        {
            return await Ok<CreateUserDto, UserInfoDto>(
                _service.RegisertCustomer,
                dto, 
                cancellationToken
            );
        }

        [HttpPost]
        public async Task<Response> RegisterDriver(CreateDriverDto dto, CancellationToken cancellationToken)
        {
            return await Ok<CreateDriverDto, UserInfoDto>(
                _service.RegisertCustomer,
                dto, 
                cancellationToken
            );
        }

        [HttpPost]
        public async Task<Response> RegisterCompany(CreateCompanyDto dto, CancellationToken cancellationToken)
        {
            return await Ok<CreateCompanyDto, UserInfoDto>(
                _service.RegisertCompany,
                dto, 
                cancellationToken
            );
        }


        [HttpPost]
        public async Task<Response> Login(LoginUserDto dto, CancellationToken cancellationToken)
        {
            return await Ok<LoginUserDto, UserInfoDto>(
                _service.Login,
                dto,
                cancellationToken
            );
        }

        // [Authorize]
        // [HttpPost]
        // public async Task<Response> Logout(CancellationToken cancellationToken)
        // {
        //     return await NoContent(
        //         _service.Logout, 
        //         cancellationToken
        //     );
        // }
    }
}
