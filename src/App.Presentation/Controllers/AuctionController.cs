using App.Application.Contracts;
using App.Application.DTOs.Auction;
using App.Application.DTOs.Common;
using App.Domain.Models.Users;
using App.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Presentation.Controllers;

public class AuctionController : BaseController<IAuctionService>
{
    public AuctionController(IAuctionService service) : base(service)
    {
    }

    [Authorize(Policy = Roles.SHOP_OWNER_ROLE)]
    [HttpPost]   
    public async Task<Response> CreateAuction(CreateAuctionDto dto, CancellationToken cancellationToken)
    {
        return await Ok(
            _service.CreateAuction,
            dto,
            cancellationToken
            );
    }

    [HttpDelete]
    [Authorize(Policy = Roles.SHOP_OWNER_OR_ADMIN)]
    public async Task<Response> DeleteAuction(Guid id, CancellationToken cancellationToken)
    {
        return await NoContent<Guid>(
            _service.DeleteAuction,
            id,
            cancellationToken
            );
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<Response> GetAuctionInfo(Guid id, CancellationToken cancellationToken)
    {
        return await Ok(
            _service.GetAuctionInfo,
            id,
            cancellationToken
            );
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<Response> GetActiveAuctions(CancellationToken cancellationToken)
    {
        return await Ok(
            _service.GetActiveAuctions,
            cancellationToken
            );
    }

    [HttpGet]
    [Authorize]
    public async Task<Response> GetUserAuctions(CancellationToken cancellationToken)
    {
        return await Ok(
            _service.GetUserAuctions,
            cancellationToken
            );
    }
}
