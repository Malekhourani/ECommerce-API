using App.Application.Contracts.Common;
using App.Application.DTOs.AuctionOffer;
using App.Application.Extensions;
using App.Domain.Exceptions.LogicalExceptions.AuctionExceptions;
using App.Domain.Models.Auctions;
using Microsoft.EntityFrameworkCore;
using TanvirArjel.EFCore.GenericRepository;
using App.Domain.Models.Auctions.AuctionOffers;
using App.Application.Services.AuctionParticipantServices;
using AutoMapper;
using App.Application.Contracts;

namespace App.Application.Services.AuctionOfferServices
{
    public class AuctionOfferService : IAuctionOfferService
    {
        private readonly IAppService _appService;
        private readonly IRepository _repo;
        private readonly IDbService _dbSerivce;
        private readonly IAuctionParticipantService _auctionParticipantService;
        private readonly IAuthenticationService _authService;
        private readonly IMapper _mapper;

        public AuctionOfferService(IRepository repo,
                                   IAuthenticationService authService,
                                   IDbService dbSerivce,
                                   IAppService appService,
                                   IAuctionParticipantService auctionParticipantService,
                                   IMapper mapper)
        {
            _repo = repo;
            _authService = authService;
            _dbSerivce = dbSerivce;
            _appService = appService;
            _auctionParticipantService = auctionParticipantService;
            _mapper = mapper;
        }

        //TODO: We Need to Push new Offers to Web App! 
        //TODO: How we will set The Winner? (X)
        //TODO: This Action Needs Refactor! (X)
        public async Task<GetAuctionOfferDto> GiveAnOffer(CreateAuctionOfferDto dto, CancellationToken cancellationToken)
        {
            using var transaction = await _repo.BeginTransactionAsync(cancellationToken: cancellationToken);

            var userId = await _authService.GetCurrentUserId(cancellationToken);

            var auction = await _repo.GetQueryable<Auction>().Where(auction => auction.Id == dto.AuctionId)
                                                                .Include(auction => auction.AuctionParticipants)
                                                                .Include(auction => auction.AuctionOffers)
                                                                .FirstOrDefaultAsync<Auction>(cancellationToken);

            if (auction.IsFinished())
            {
                auction.MarkAsSold();
                await transaction!.CommitAsync(cancellationToken);
                throw new AuctionHasAlreadyEndedException();
            }

            var isAParticipant = await _auctionParticipantService.IsParticipant(dto.AuctionId, userId, cancellationToken);

            if (!isAParticipant) throw new UserNeedToJoinTheAuctionBeforeMakeAnOfferException();

            auction.CheckIfCanAcceptNewOffers();

            auction.ValidateNewOffer(dto.Price);

            var offer = await CreateOffer(dto.Price, auction.Id, userId, cancellationToken);

            await transaction!.CommitAsync(cancellationToken);

            return _mapper.Map<AuctionOffer, GetAuctionOfferDto>(offer);
        }

        public async Task<AuctionOffer> CreateOffer(double newOfferPrice, Guid auctionId, string userId, CancellationToken cancellationToken)
        {
            var newOffer = AuctionOffer.Factory(newOfferPrice, userId, auctionId);

            var offerKeys = await _dbSerivce.CreateAsync<AuctionOffer>(newOffer, cancellationToken);

            newOffer.Id = offerKeys[0].CastTo<Guid>();

            return newOffer;
        }
    }
}
