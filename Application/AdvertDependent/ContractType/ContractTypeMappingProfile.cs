﻿using Application.AdvertDependent.ContractType.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.ContractType
{
    public class ContractTypeMappingProfile : Profile
    {
        public ContractTypeMappingProfile()
        {
            CreateMap<Core.Entities.AdvertDependent.ContractType, ContractTypeDTO>()
                .ReverseMap();
        }
    }
}
