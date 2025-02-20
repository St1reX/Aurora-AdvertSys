using Application.Company.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Company.Queries.GetAllCompanies
{
    public class GetAllCompaniesQuery : IRequest<ICollection<CompanyDTO>?>
    {
    }
}
