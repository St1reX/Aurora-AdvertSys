using Application.SeniorityLevel.DTOs;
using AutoMapper;

namespace Application.SeniorityLevel
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
