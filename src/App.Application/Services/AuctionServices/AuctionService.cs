using App.Application.Contracts.Common;
using App.Application.DTOs.Auction;
using App.Application.DTOs.Common;
using App.Domain.Models.Auctions;
using App.Application.Extensions;
using App.Domain.Models.Auctions.AuctionParticipants;
using TanvirArjel.EFCore.GenericRepository;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using App.Application.Contracts;
using App.Application.Services.AuctionParticipantServices;

namespace App.Application.Services.AuctionServices
{
    public class AuctionService : IAuctionService
    {
        private readonly IRepository _repo;
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IDbService _dbService;
        private readonly IAuthenticationService _authService;
        private readonly IAuctionParticipantService _participantService;

        public AuctionService(IAuthenticationService authService, IRepository repo, IDbService dbService, IMapper mapper, IProductService productService, IAuctionParticipantService participantService)
        {
            _repo = repo;
            _dbService = dbService;
            _authService = authService;
            _mapper = mapper;
            _productService = productService;
            _participantService = participantService;
        }

        public async Task<Guid> CreateAuction(CreateAuctionDto dto, CancellationToken cancellationToken)
        {
            dto.Validate();

            // using var transaction = await _repo.BeginTransactionAsync(cancellationToken: cancellationToken);

            var currentUserId = await _authService.GetCurrentUserId(cancellationToken);

            var product = await _productService.GetProduct(dto.ProductId, cancellationToken);

            var auction = Auction.Factory(dto.StartDate, dto.EndDate, dto.InitialPrice, dto.MinOfferPrice, dto.ProductId, currentUserId);

            var auctionId = (await _dbService.CreateAsync(auction, cancellationToken))[0].CastTo<Guid>();

            // await _participantService.JoinAuction(auctionId, cancellationToken);

            // await transaction.CommitAsync(cancellationToken);

            return auctionId;
        }

        public Task DeleteAuction(Guid id, CancellationToken cancellationToken)
        {
            // return _dbService.SoftDeleteAsync<Auction>(id, cancellationToken);
            return _dbService.DeleteAsync<Auction>(id, cancellationToken);
        }

        public async Task<GetAuctionInfoDto> GetAuctionInfo(Guid id, CancellationToken cancellationToken)
        {
            var auction = await _repo.GetQueryable<Auction>()
                                    .Include(auction => auction.AuctionOffers)
                                    .Include(auction => auction.AuctionParticipants)
                                    .Include(auction => auction.Creator)
                                    .Include(auction => auction.Product)
                                    .Include(auction => auction.WinnerOffer)
                                    .FirstOrDefaultAsync(auction => auction.Id == id, cancellationToken);

            return _mapper.Map<Auction, GetAuctionInfoDto>(auction);
        }

        // public async Task<IEnumerable<GetActiveAuctionDto>> GetActiveAuctions(GetPageDto dto, CancellationToken cancellationToken)
        public async Task<IEnumerable<GetActiveAuctionDto>> GetActiveAuctions(CancellationToken cancellationToken)

        {
            var data = await _repo.GetQueryable<Auction>()
                                        .Include(auction => auction.Creator)
                                        .Include(auction => auction.Product)
                                        .Where(auction => !auction.IsClosed && !auction.IsDeleted)
                                        .OrderByDescending(auction => auction.Id)
                                        .Select(row => new GetActiveAuctionDto
                                        {
                                            Id = row.Id,
                                            EndDate = row.EndDate,
                                            StartDate = row.StartDate,
                                            InitialPrice = row.InitialPrice,
                                            MinOfferPrice = row.MinOfferPrice,
                                            Creator = new DTOs.User.GetApplicationUserInfoDto
                                            {
                                                Id = row.CreatorId,
                                                Name = row.Creator.UserName
                                            },
                                            Product = new DTOs.Product.GetGeneralProductInfoDto
                                            {
                                                Id = row.ProductId,
                                                Name = row.Product.Name,
                                                Price = row.Product.Price
                                            }
                                        })
                                        .ToListAsync(cancellationToken);

            return data;
        }

        // public async Task<IEnumerable<GetActiveAuctionDto>> GetUserAuctions(GetPageDto dto, CancellationToken cancellationToken)
        public async Task<IEnumerable<GetActiveAuctionDto>> GetUserAuctions(CancellationToken cancellationToken)
        {
            var userId = await _authService.GetCurrentUserId(cancellationToken);

            var auctionEntities = await _repo.GetQueryable<AuctionParticipant>()
                                        .Include(row => row.Auction.Creator)
                                        .Include(auction => auction.Auction.Product)
                                        .Where(row => row.ApplicationUserId == userId && !row.Auction.IsDeleted)
                                        .Select(row => new GetActiveAuctionDto
                                        {
                                            Id = row.AuctionId,
                                            EndDate = row.Auction.EndDate,
                                            StartDate = row.Auction.StartDate,
                                            InitialPrice = row.Auction.InitialPrice,
                                            MinOfferPrice = row.Auction.MinOfferPrice,
                                            Creator = new DTOs.User.GetApplicationUserInfoDto
                                            {
                                                Id = row.Auction.CreatorId,
                                                Name = row.Auction.Creator.UserName
                                            },
                                            Product = new DTOs.Product.GetGeneralProductInfoDto
                                            {
                                                Id = row.Auction.ProductId,
                                                Name = row.Auction.Product.Name,
                                                Price = row.Auction.Product.Price
                                            }
                                        })
                                        // .Skip((dto.PageId - 1) * dto.PageSize)
                                        // .Take(dto.PageSize)
                                        .ToListAsync(cancellationToken);

            return auctionEntities;
        }
    }
}
