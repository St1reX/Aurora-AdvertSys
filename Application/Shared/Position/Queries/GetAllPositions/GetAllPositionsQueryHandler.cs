using Application.Shared.Position.DTOs;
using AutoMapper;
using Core.Interfaces.Shared;
using MediatR;

namespace Application.Shared.Position.Queries.GetAllPositions
{
    public class GetAllPositionsQueryHandler : IRequestHandler<GetAllPositionsQuery, ICollection<PositionDTO>?>
    {
        private readonly IPositionRepository positionRepository;
        private readonly IMapper mapper;

        public GetAllPositionsQueryHandler(IPositionRepository positionRepository, IMapper mapper)
        {
            this.positionRepository = positionRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<PositionDTO>?> Handle(GetAllPositionsQuery request, CancellationToken cancellationToken)
        {
            var positions = await positionRepository.GetAllPositions();
            var positionsDTO = mapper.Map<ICollection<PositionDTO>?>(positions);

            return positionsDTO;
        }
    }
}
