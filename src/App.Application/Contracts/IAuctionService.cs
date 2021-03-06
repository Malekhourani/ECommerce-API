using App.Application.DTOs.Auction;
using App.Application.DTOs.Common;

namespace App.Application.Contracts;

public interface IAuctionService
{
    Task<Guid> CreateAuction(CreateAuctionDto dto, CancellationToken cancellationToken);

    Task DeleteAuction(Guid id, CancellationToken cancellationToken);

    Task<GetAuctionInfoDto> GetAuctionInfo(Guid id, CancellationToken cancellationToken);

    Task<IEnumerable<GetActiveAuctionDto>> GetActiveAuctions(CancellationToken cancellationToken);

    Task<IEnumerable<GetActiveAuctionDto>> GetUserAuctions(CancellationToken cancellationToken);
}
