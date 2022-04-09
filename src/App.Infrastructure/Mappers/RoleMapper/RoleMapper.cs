using System;
using App.Application.DTOs.Role;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace App.Infrastructure.Mappers.RoleMapper
{
    public class RoleMapper : Profile
    {
        public RoleMapper()
        {
            CreateMap<IdentityRole, GetRoleDto>();
        }
    }
}
