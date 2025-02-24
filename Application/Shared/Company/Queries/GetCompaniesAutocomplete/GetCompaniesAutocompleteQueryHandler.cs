using Application.Shared.Company.DTOs;
using AutoMapper;
using Core.Interfaces.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.Company.Queries.GetCompaniesAutocomplete
{
    public class GetCompaniesAutocompleteQueryHandler : IRequestHandler<GetCompaniesAutocompleteQuery, ICollection<CompanySuggestionDTO>?>
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;

        public GetCompaniesAutocompleteQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            this.companyRepository = companyRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<CompanySuggestionDTO>?> Handle(GetCompaniesAutocompleteQuery request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.CompanyName))
            {
                return [];
            }

            var companies = await companyRepository.GetCompaniesAutocomplete(request.CompanyName);
            var companiesDTO = mapper.Map<ICollection<CompanySuggestionDTO>?>(companies);

            return companiesDTO;
        }
    }
}
