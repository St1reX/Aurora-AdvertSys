using Application.Shared.Company.DTOs;
using AutoMapper;
using Core.Interfaces.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.Company.Queries.GetAllCompanies
{
    public class GetAllCompaniesQueryHandler : IRequestHandler<GetAllCompaniesQuery, ICollection<CompanyDTO>?>
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;

        public GetAllCompaniesQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            this.companyRepository = companyRepository;
            this.mapper = mapper;
        }
        public async Task<ICollection<CompanyDTO>?> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
        {
            var companies = await companyRepository.GetAllCompanies();
            var companiesDTO = mapper.Map<ICollection<CompanyDTO>?>(companies);

            return companiesDTO;

        }
    }
}
