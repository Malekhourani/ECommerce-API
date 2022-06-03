using App.Application.Contracts;
using App.Application.DTOs.AuctionOffer;
using App.Application.DTOs.Common;
using App.Presentation.Controllers.Common;
using App.Presentation.Hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using CustomeResponse = App.Application.DTOs.Common.Response;

namespace App.Presentation.Controllers;

public class AuctionOfferController : BaseController<IAuctionOfferService>
{
    private readonly IHubContext<NotificationHub> _hubContext;
    public AuctionOfferController(IAuctionOfferService service, IHubContext<NotificationHub> hubContext) : base(service)
    {
        _hubContext = hubContext;
    }

    [HttpPost]
    [Authorize]
    public async Task<CustomeResponse> GiveAnOffer(CreateAuctionOfferDto dto, CancellationToken cancellationToken)
    {
        var result = await _service.GiveAnOffer(dto, cancellationToken);

        await _hubContext.Clients.Group(dto.AuctionId.ToString())
                                .SendAsync("NewOfferReceived", $"a new offer, and its value is {dto.Price}!");

        return CustomeResponse.Ok(result);
    }

    [HttpGet("{lastReceivedId:Guid}/auction/{auctionId:Guid}")]
    [Authorize]
    public async Task<CustomeResponse> GetNewOffers([FromRoute] Guid lastReceivedId, [FromRoute] Guid auctionId, [FromQuery] DateTime lastReceivedDate, CancellationToken cancellationToken)
    {
        var result = await _service.GetNewOffers(auctionId, lastReceivedId, lastReceivedDate, cancellationToken);

        return CustomeResponse.Ok(result);
    }
}
