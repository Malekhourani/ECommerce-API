using App.Application.DTOs.Company;
using App.Application.DTOs.User;
using App.Domain.Models.Users;
using App.Services.Hashing;
using AutoMapper;

namespace App.Infrastructure.Mappers.UserMapper;
public class CompanyMapper : Profile
{
    public CompanyMapper()
    {
        CreateMap<ApplicationUser, GetCompanyGeneralInfoDto>()
                .ForMember(dto => dto.CompanyId, opt => opt.MapFrom(user => user.Id))
                .ForMember(dto => dto.CompanyName, opt => opt.MapFrom(user => user.UserName));

        CreateMap<CreateCompanyDto, ApplicationUser>()
                    .ForMember(user => user.UserName, opt => opt.MapFrom(dto => dto.CompanyName))
                    .ForMember(user => user.NormalizedUserName, opt => opt.MapFrom(dto => dto.CompanyName.ToUpper()))
                    .ForSourceMember(dto => dto.RePassword, opt => opt.DoNotValidate())
                    .BeforeMap((dto, user) =>
                    {
                        user.PasswordHash = dto.Password;
                        //  PasswordHashingHelper.Hash<ApplicationUser>(user, dto.Password);
                    });
    }
}

