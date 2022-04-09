using App.Application.DTOs.AuctionParticipant;

namespace App.Application.Services.AuctionParticipantServices;

public interface IAuctionParticipantService
{
    Task JoinAuction(Guid auctionId, CancellationToken cancellationToken);
    Task LeaveAuction(Guid auctionId, CancellationToken cancellationToken);
    Task<bool> IsParticipant(Guid auctionId, string userId, CancellationToken cancellationToken);
}
