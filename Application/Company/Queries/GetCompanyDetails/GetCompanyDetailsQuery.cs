using Application.Company.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Company.Queries.GetCompanyDetails
{
    public class GetCompanyDetailsQuery : IRequest<CompanyDTO?>
    {
        public int CompanyID { get; set; }
    }
}
