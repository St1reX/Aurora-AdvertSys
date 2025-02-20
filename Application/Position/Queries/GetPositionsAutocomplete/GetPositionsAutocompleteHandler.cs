using Application.Position.DTOs;
using AutoMapper;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Position.Queries.GetPositionsAutocomplete
{
    public class GetPositionsAutocompleteHandler : IRequestHandler<GetPositionsAutocompleteQuery, ICollection<PositionDTO>?>
    {
        private readonly IPositionRepository positionRepository;
        private readonly IMapper mapper;

        public GetPositionsAutocompleteHandler(IPositionRepository positionRepository, IMapper mapper)
        {
            this.positionRepository = positionRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<PositionDTO>?> Handle(GetPositionsAutocompleteQuery request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.PositionName))
            {
                return [];
            }

            var positions = await positionRepository.GetPositionsAutocomplete(request.PositionName);
            var positionsDTO = mapper.Map<ICollection<PositionDTO>?>(positions);

            return positionsDTO;
        }
    }
}
