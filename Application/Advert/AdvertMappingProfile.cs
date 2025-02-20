using Application.Advert.DTOs;
using AutoMapper;

namespace Application.Advert
{
    public class AdvertMappingProfile : Profile
    {
        public AdvertMappingProfile()
        {
            CreateMap<Core.Entities.Advert, AdvertDTO>()
                .ForMember(dest => dest.WorkTime, opt => opt.MapFrom(src => $"From {src.WorkTimeFrom} to {src.WorkTimeTo}"))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.CompanyName))
                .ForMember(dest => dest.PositionName, opt => opt.MapFrom(src => src.Position.PositionName))
                .ForMember(dest => dest.SeniorityLevelName, opt => opt.MapFrom(src => src.SeniorityLevel.SeniorityLevelName));


            CreateMap<Core.Entities.Advert, AdvertDetailsDTO>()
            .ForMember(dest => dest.WorkTime, opt =>
                opt.MapFrom(src => $"From {src.WorkTimeFrom} to {src.WorkTimeTo}"))
            .ForMember(dest => dest.CompanyName, opt =>
                opt.MapFrom(src => src.Company.CompanyName))
            .ForMember(dest => dest.PositionName, opt =>
                opt.MapFrom(src => src.Position.PositionName))
            .ForMember(dest => dest.SeniorityLevelName, opt =>
                opt.MapFrom(src => src.SeniorityLevel.SeniorityLevelName))
            .ForMember(dest => dest.JobSectorName, opt =>
                opt.MapFrom(src => src.JobSector.JobSectorName))
            .ForMember(dest => dest.ContractTypeName, opt =>
                opt.MapFrom(src => src.ContractType.ContractTypeName))
            .ForMember(dest => dest.EmploymentTypeName, opt =>
                opt.MapFrom(src => src.EmploymentType.EmploymentTypeName))
            .ForMember(dest => dest.WorkModelName, opt =>
                opt.MapFrom(src => src.WorkModel.WorkModelName))
            .ForMember(dest => dest.WorkDaysName, opt =>
                opt.MapFrom(src => src.WorkDays.WorkDaysName))
            .ForMember(dest => dest.Address, opt =>
                opt.MapFrom(src => src.AdvertAddress));
        }
    }
}
