using Application.EmploymentType.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmploymentType.Queries.GetAllEmploymentTypes
{
    public class GetAllEmploymentTypesQuery : IRequest<IEnumerable<EmploymentTypeDTO>?>
    {
    }
}
