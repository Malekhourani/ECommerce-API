using App.Application.DTOs.Auction;
using App.Application.DTOs.AuctionOffer;
using App.Application.DTOs.Product;
using App.Application.DTOs.User;
using App.Domain.Models.Auctions;
using App.Domain.Models.Auctions.AuctionOffers;
using App.Domain.Models.Auctions.AuctionParticipants;
using App.Domain.Models.Products;
using App.Domain.Models.Users;
using AutoMapper;

namespace App.Infrastructure.Mappers.AuctionMapper;

public class AuctionMapper : Profile
{
    public AuctionMapper()
    {
        CreateMap<Auction, GetAuctionInfoDto>()
                    .ForPath(dest => dest.Product, opt => opt.MapFrom(src => src.Product))
                    .ForPath(dest => dest.Offers, opt => opt.MapFrom(src => src.AuctionOffers))
                    .ForPath(dest => dest.Winner.Id, opt => opt.MapFrom(src => src.WinnerOffer != null && src.WinnerOffer.ApplicationUser != null ? src.WinnerOffer.ApplicationUserId : null))
                    .ForPath(dest => dest.Winner.Name, opt => opt.MapFrom(src => src.WinnerOffer != null && src.WinnerOffer.ApplicationUser != null ? src.WinnerOffer.ApplicationUser.UserName : null));

        CreateMap<AuctionOffer, GetAuctionOfferDto>()
                    .ForPath(dest => dest.Paticipant, opt => opt.MapFrom(src => src.ApplicationUser));

        CreateMap<AuctionOffer, GetApplicationUserInfoDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ApplicationUserId))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ApplicationUser != null ? src.ApplicationUser.UserName : null));

        CreateMap<Auction, GetActiveAuctionDto>()
                    .ForPath(dest => dest.Product, opt => opt.MapFrom(src => src.Product));

        CreateMap<AuctionParticipant, GetActiveAuctionDto>()
                    .ForPath(dest => dest.Product, opt => opt.MapFrom(src => src.Auction.Product))
                    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Auction.Creator))
                    .ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.AuctionId))
                    .ForPath(dest => dest.EndDate, opt => opt.MapFrom(src => src.Auction.EndDate))
                    .ForPath(dest => dest.InitialPrice, opt => opt.MapFrom(src => src.Auction.InitialPrice))
                    .ForPath(dest => dest.MinOfferPrice, opt => opt.MapFrom(src => src.Auction.MinOfferPrice))
                    .ForPath(dest => dest.StartDate, opt => opt.MapFrom(src => src.Auction.StartDate));
    }
}
