using Application.JobSector.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobSector.Queries.GetAllJobSectors
{
    public class GetAllJobSectorsQuery : IRequest<IEnumerable<JobSectorDTO>?>
    {
    }
}
