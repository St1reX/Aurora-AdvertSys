using Application.Advert.DTOs;
using Application.ContractType.DTOs;
using AutoMapper;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ContractType.Queries.GetAllContractTypes
{
    public class GetAllContractTypesQueryHandler : IRequestHandler<GetAllContractTypesQuery, IEnumerable<ContractTypeDTO>?>
    {
        private readonly IContractTypeRepository contractTypeRepository;
        private readonly IMapper mapper;

        public GetAllContractTypesQueryHandler(IContractTypeRepository contractTypeRepository, IMapper mapper)
        {
            this.contractTypeRepository = contractTypeRepository;
            this.mapper = mapper;
        }

        async Task<IEnumerable<ContractTypeDTO>?> IRequestHandler<GetAllContractTypesQuery, IEnumerable<ContractTypeDTO>?>.Handle(GetAllContractTypesQuery request, CancellationToken cancellationToken)
        {
            var contractTypes = await contractTypeRepository.GetAllContractTypes();
            var contractTypesDTO = mapper.Map<IEnumerable<ContractTypeDTO>?>(contractTypes);

            return contractTypesDTO;
        }
    }
}
