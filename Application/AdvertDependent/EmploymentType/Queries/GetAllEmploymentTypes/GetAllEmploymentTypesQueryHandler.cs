using Application.AdvertDependent.EmploymentType.DTOs;
using AutoMapper;
using Core.Entities.AdvertDependent;
using Core.Interfaces.AdvertDependent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.EmploymentType.Queries.GetAllEmploymentTypes
{
    public class GetAllEmploymentTypesQueryHandler : IRequestHandler<GetAllEmploymentTypesQuery, IEnumerable<EmploymentTypeDTO>?>
    {
        private readonly IEmploymentTypeRepository employmentTypeRepository;
        private readonly IMapper mapper;

        public GetAllEmploymentTypesQueryHandler(IEmploymentTypeRepository employmentTypeRepository, IMapper mapper)
        {
            this.employmentTypeRepository = employmentTypeRepository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<EmploymentTypeDTO>?> Handle(GetAllEmploymentTypesQuery request, CancellationToken cancellationToken)
        {
            var employmentTypes = await employmentTypeRepository.GetAllEmploymentTypes();
            var employmentTypesDTO = mapper.Map<IEnumerable<EmploymentTypeDTO>?>(employmentTypes);

            return employmentTypesDTO;
        }
    }
}
