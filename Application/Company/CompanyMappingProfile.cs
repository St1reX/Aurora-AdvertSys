using Application.Company.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Company
{
    public class CompanyMappingProfile : Profile
    {
        public CompanyMappingProfile()
        {
            CreateMap<Core.Entities.Shared.Company.Company, CompanyDTO>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.CompanyAddress));

            CreateMap<Core.Entities.Shared.Company.Company, CompanySuggestionDTO>()
                .ReverseMap();
        }
    }
}
