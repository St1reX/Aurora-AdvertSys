using Application.AdvertDependent.SeniorityLevel.DTOs;
using AutoMapper;

namespace Application.AdvertDependent.SeniorityLevel
{
    public class SeniorityLevelMappingProfile : Profile
    {
        public SeniorityLevelMappingProfile()
        {
            CreateMap<Core.Entities.AdvertDependent.SeniorityLevel, SeniorityLevelDTO>()
                .ReverseMap();
        }
    }
}
