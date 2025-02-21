using Application.JobSector.DTOs;
using AutoMapper;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobSector.Queries.GetAllJobSectors
{
    public class GetAllJobSectorsQueryHandler : IRequestHandler<GetAllJobSectorsQuery, IEnumerable<JobSectorDTO>?>
    {
        private readonly IJobSectorRepository jobSectorRepository;
        private readonly IMapper mapper;

        public GetAllJobSectorsQueryHandler(IJobSectorRepository jobSectorRepository, IMapper mapper)
        {
            this.jobSectorRepository = jobSectorRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<JobSectorDTO>?> Handle(GetAllJobSectorsQuery request, CancellationToken cancellationToken)
        {
            var jobSectors = await jobSectorRepository.GetAllJobSectors();
            var jobSectorsDTO = mapper.Map<IEnumerable<JobSectorDTO>?>(jobSectors);

            return jobSectorsDTO;
        }
    }
}
