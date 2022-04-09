using App.Application.Contracts;
using App.Application.DTOs.Auction;
using App.Application.DTOs.Common;
using App.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Presentation.Controllers;

public class AuctionController : BaseController<IAuctionService>
{
    public AuctionController(IAuctionService service) : base(service)
    {
    }

    [HttpPost]
    [Authorize(Policy = "ShopOwnerOrCustomer")]
    public async Task<Response> CreateAuction(CreateAuctionDto dto, CancellationToken cancellationToken)
    {
        return await Ok(
            _service.CreateAuction,
            dto,
            cancellationToken
            );
    }

    [HttpDelete]
    [Authorize]
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

    [HttpPost]
    [AllowAnonymous]
    public async Task<Response> GetActiveAuctions(GetPageDto dto, CancellationToken cancellationToken)
    {
        return await Ok(
            _service.GetActiveAuctions,
            dto,
            cancellationToken
            );
    }

    [HttpPost]
    [Authorize]
    public async Task<Response> GetUserAuctions(GetPageDto dto, CancellationToken cancellationToken)
    {
        return await Ok(
            _service.GetUserAuctions,
            dto,
            cancellationToken
            );
    }
}
