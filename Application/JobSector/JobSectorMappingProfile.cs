using Application.JobSector.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobSector
{
    public class JobSectorMappingProfile : Profile
    {
        public JobSectorMappingProfile()
        {
            CreateMap<Core.Entities.AdvertDependent.JobSector, JobSectorDTO>()
                .ReverseMap();
        }
    }
}
