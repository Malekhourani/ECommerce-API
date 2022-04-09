using App.Application.DTOs.AuctionOffer;

namespace App.Application.Contracts;

public interface IAuctionOfferService
{
    Task<GetAuctionOfferDto> GiveAnOffer(CreateAuctionOfferDto dto, CancellationToken cancellationToken);
}
