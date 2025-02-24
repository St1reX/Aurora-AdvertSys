using AutoMapper;

namespace Application.Shared.Position
{
    public class PositionMappingProfile : Profile
    {
        public PositionMappingProfile()
        {
            CreateMap<Core.Entities.Shared.Position, DTOs.PositionDTO>();
        }
    }
}
