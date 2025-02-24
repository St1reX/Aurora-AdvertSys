using Application.AdvertDependent.ContractType.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.ContractType.Queries.GetAllContractTypes
{
    public class GetAllContractTypesQuery : IRequest<IEnumerable<ContractTypeDTO>?>
    {
    }
}
