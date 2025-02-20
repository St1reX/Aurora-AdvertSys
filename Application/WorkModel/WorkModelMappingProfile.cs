using Application.WorkModel.DTOs;
using AutoMapper;

namespace Application.WorkModel
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
