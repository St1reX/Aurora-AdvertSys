using Application.SeniorityLevel.DTOs;
using AutoMapper;
using Core.Entities.AdvertDependent;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SeniorityLevel.Queries.GetAllSeniorityLevels
{
    public class GetAllSeniorityLevelsQueryHandler : IRequestHandler<GetAllSeniorityLevelsQuery, IEnumerable<SeniorityLevelDTO>?>
    {
        private readonly ISeniorityLevelRepository seniorityLevelRepository;
        private readonly IMapper mapper;

        public GetAllSeniorityLevelsQueryHandler(ISeniorityLevelRepository seniorityLevelRepository, IMapper mapper)
        {
            this.seniorityLevelRepository = seniorityLevelRepository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<SeniorityLevelDTO>?> Handle(GetAllSeniorityLevelsQuery request, CancellationToken cancellationToken)
        {
            var seniorityLevels = await seniorityLevelRepository.GetAllSeniorityLevels();
            var seniorityLevelsDTO = mapper.Map<IEnumerable<SeniorityLevelDTO>>(seniorityLevels);

            return seniorityLevelsDTO;
        }
    }
}
