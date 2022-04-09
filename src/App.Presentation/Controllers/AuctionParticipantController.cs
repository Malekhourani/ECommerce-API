using App.Application.DTOs.Common;
using App.Application.Services.AuctionParticipantServices;
using App.Presentation.Controllers.Common;
using App.Presentation.Hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace App.Presentation.Controllers;

public class AuctionParticipantController : BaseController<IAuctionParticipantService>
{
    private readonly IHubContext<NotificationHub> _hubContext;

    public AuctionParticipantController(IAuctionParticipantService service, IHubContext<NotificationHub> hubContext) : base(service)
    {
        _hubContext = hubContext;
    }

    [Authorize]
    [HttpPost]
    public async Task<Response> JoinAuction(Guid auctionId, CancellationToken cancellationToken)
    {
        var result = await NoContent<Guid>(
            _service.JoinAuction,
            auctionId,
            cancellationToken
            );

        await _hubContext.Clients.Group(auctionId.ToString())
                                .SendAsync("NewNotification", $"a new user joined the auction");

        return result;
    }

    [Authorize]
    [HttpPost]
    public async Task<Response> LeaveAuction(Guid auctionId, CancellationToken cancellationToken)
    {
        var result =  await NoContent<Guid>(
            _service.LeaveAuction,
            auctionId,
            cancellationToken
            ); 

        await _hubContext.Clients.Group(auctionId.ToString())
                                .SendAsync("NewNotification", $"user leaved the auction");

        return result;
    }
}
