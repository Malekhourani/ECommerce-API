using App.Application.DTOs.Driver;
using App.Application.DTOs.User;
using App.Domain.Models.Users;
using AutoMapper;

namespace App.Infrastructure.Mappers.UserMapper;

public class DriverMapper : Profile
{
    public DriverMapper()
    {
        CreateMap<ApplicationUser, GetDriverGeneralInfoDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(user => user.Id))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(user => user.PhoneNumber))
                .ForMember(dto => dto.Email, opt => opt.MapFrom(user => user.Email));

        CreateMap<CreateDriverDto, ApplicationUser>()
                    .ForMember(user => user.UserName, opt => opt.MapFrom(dto => dto.Email))
                    .ForMember(user => user.NormalizedUserName, opt => opt.MapFrom(dto => dto.Email.ToUpper()))
                    .ForSourceMember(dto => dto.RePassword, opt => opt.DoNotValidate())
                    .BeforeMap((dto, user) =>
                    {
                        user.PasswordHash = dto.Password;
                    });
    }
}
