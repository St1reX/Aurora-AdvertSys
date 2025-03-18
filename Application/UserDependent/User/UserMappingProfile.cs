using Application.UserDependent.User.DTOs;
using AutoMapper;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserDependent.User
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile() 
        {
           CreateMap<UserRegisterDTO, ApplicationUser>()
                .ReverseMap();
        }
    }
}
