using Application.AdvertDependent.EmploymentType.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.EmploymentType
{
    public class EmploymentTypeMappingProfile : Profile
    {
        public EmploymentTypeMappingProfile()
        {
            CreateMap<Core.Entities.AdvertDependent.EmploymentType, EmploymentTypeDTO>()
                .ReverseMap();
        }
    }
}
