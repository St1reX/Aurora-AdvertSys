using Application.Company.DTOs;
using AutoMapper;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Company.Queries.GetCompanyDetails
{
    public class GetCompanyDetailsQueryHandler : IRequestHandler<GetCompanyDetailsQuery, CompanyDTO?>
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;

        public GetCompanyDetailsQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            this.companyRepository = companyRepository;
            this.mapper = mapper;
        }

        public async Task<CompanyDTO?> Handle(GetCompanyDetailsQuery request, CancellationToken cancellationToken)
        {
            var company = await companyRepository.GetCompanyById(request.CompanyID);
            var companyDTO = mapper.Map<CompanyDTO>(company);

            return companyDTO;
        }
    }
}
