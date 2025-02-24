using Application.AdvertDependent.WorkModel.DTOs;
using AutoMapper;

namespace Application.AdvertDependent.WorkModel
{
    public class WorkModelMappingProfile : Profile
    {
        public WorkModelMappingProfile()
        {
            CreateMap<Core.Entities.AdvertDependent.WorkModel, WorkModelDTO>()
                .ReverseMap();
        }
    }
}
