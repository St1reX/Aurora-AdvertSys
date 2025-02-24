using Application.AdvertDependent.WorkModel.DTOs;
using AutoMapper;
using Core.Interfaces.AdvertDependent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.WorkModel.Queries.GetAllWorkModels
{
    public class GetAllWorkModelsQueryHandler : IRequestHandler<GetAllWorkModelsQuery, IEnumerable<WorkModelDTO>>
    {
        private readonly IWorkModelRepository workModelRepository;
        private readonly IMapper mapper;

        public GetAllWorkModelsQueryHandler(IWorkModelRepository workModelRepository, IMapper mapper)
        {
            this.workModelRepository = workModelRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WorkModelDTO>> Handle(GetAllWorkModelsQuery request, CancellationToken cancellationToken)
        {
            var workModels = await workModelRepository.GetAllWorkModels();
            var workModelsDTO = mapper.Map<IEnumerable<WorkModelDTO>>(workModels);

            return workModelsDTO;
        }
    }
}
