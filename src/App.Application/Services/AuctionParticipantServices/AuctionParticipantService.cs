using System;
using App.Application.Contracts.Common;
using App.Application.DTOs.AuctionParticipant;
using App.Application.DTOs.Common;
using App.Application.Extensions;
using App.Domain.Exceptions.LogicalExceptions.CommonExceptions;
using App.Domain.Models.Auctions.AuctionParticipants;
using Microsoft.EntityFrameworkCore;
using TanvirArjel.EFCore.GenericRepository;

namespace App.Application.Services.AuctionParticipantServices
{
    public class AuctionParticipantService : IAuctionParticipantService
    {
        private readonly IDbService _dbService;
        private readonly IRepository _repository;
        private readonly IAuthenticationService _authService;

        public AuctionParticipantService(IDbService dbService, IAuthenticationService authService, IRepository repository)
        {
            _dbService = dbService;
            _authService = authService;
            _repository = repository;
        }

        public async Task JoinAuction(Guid auctionId, CancellationToken cancellationToken)
        {
            var currentUserId = await _authService.GetCurrentUserId(cancellationToken);

            if(await IsParticipant(auctionId, currentUserId, cancellationToken)) throw new BadRequestException("User is already joined this auction");

            var participant = AuctionParticipant.Factory(auctionId, currentUserId);

            await _dbService.CreateAsync(participant, cancellationToken);
        }

        public async Task LeaveAuction(Guid auctionId, CancellationToken cancellationToken)
        {
            var currentUserId = await _authService.GetCurrentUserId(cancellationToken);

            if(!await IsParticipant(auctionId, currentUserId, cancellationToken)) throw new BadRequestException("User is Not a participant");

            await _dbService.DeleteAsync<AuctionParticipant>(row => row.ApplicationUserId == currentUserId && row.AuctionId == auctionId, cancellationToken);
        }

        public async Task<bool> IsParticipant(Guid auctionId, string userId, CancellationToken cancellationToken)
        {
            var row = await _repository.GetQueryable<AuctionParticipant>()
                                                .Where(participant => participant.ApplicationUserId == userId && participant.AuctionId == auctionId)
                                                .FirstOrDefaultAsync(cancellationToken);

            return row is not null;
        }
    }
}
