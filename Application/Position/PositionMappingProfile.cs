using AutoMapper;

namespace Application.Position
{
    public class PositionMappingProfile : Profile
    {
        public PositionMappingProfile()
        {
            CreateMap<Core.Entities.Shared.Position, DTOs.PositionDTO>();
        }
    }
}
