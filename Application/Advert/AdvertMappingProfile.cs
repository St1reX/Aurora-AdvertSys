using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert
{
    public class AdvertMappingProfile : Profile
    {
        public AdvertMappingProfile()
        {
            CreateMap<Core.Entities.Advert, DTOs.AdvertDTO>()
                .ForMember(dest => dest.WorkTime, opt => opt.MapFrom(src => "From " + System.Convert.ToString(src.WorkTimeFrom) + " to " + System.Convert.ToString(src.WorkTimeTo)))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.CompanyName))
                .ForMember(dest => dest.PositionName, opt => opt.MapFrom(src => src.Position.PositionName))
                .ForMember(dest => dest.SeniorityLevelName, opt => opt.MapFrom(src => src.SeniorityLevel.SeniorityLevelName));

            CreateMap<DTOs.AdvertFilterDTO, Core.Helpers.AdvertFilter>()
                .ReverseMap();
        }
    }
}
