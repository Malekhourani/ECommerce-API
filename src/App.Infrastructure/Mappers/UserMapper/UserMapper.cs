using System;
using App.Application.DTOs.User;
using App.Domain.Models.Users;
using App.Services.Hashing;
using AutoMapper;

namespace App.Infrastructure.Mappers.UserMapper
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<CreateUserDto, ApplicationUser>()
                    .ForMember(user => user.UserName, opt => opt.MapFrom(dto => dto.Email))
                    .ForMember(user => user.NormalizedUserName, opt => opt.MapFrom(dto => dto.Email.ToUpper()))
                    .ForSourceMember(dto => dto.RePassword, opt => opt.DoNotValidate())
                    .BeforeMap((dto, user) =>
                    {
                        user.PasswordHash = dto.Password;
                        //  PasswordHashingHelper.Hash<ApplicationUser>(user, dto.Password);
                    });

            CreateMap<ApplicationUser, GetApplicationUserInfoDto>()
                    .ForMember(user => user.Name, opt => opt.MapFrom(dto => dto.Email));
        }
    }
}
