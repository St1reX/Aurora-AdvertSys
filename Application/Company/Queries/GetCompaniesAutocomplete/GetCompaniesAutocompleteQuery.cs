using Application.Company.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Company.Queries.GetCompaniesAutocomplete
{
    public class GetCompaniesAutocompleteQuery : IRequest<ICollection<CompanySuggestionDTO>?>
    {
        public string? CompanyName { get; set; }
    }
}
