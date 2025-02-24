using Application.AdvertDependent.JobSector.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.JobSector.Queries.GetAllJobSectors
{
    public class GetAllJobSectorsQuery : IRequest<IEnumerable<JobSectorDTO>?>
    {
    }
}
