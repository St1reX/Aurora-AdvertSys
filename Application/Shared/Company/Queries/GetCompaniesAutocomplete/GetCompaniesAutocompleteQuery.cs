﻿using Application.Shared.Company.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.Company.Queries.GetCompaniesAutocomplete
{
    public class GetCompaniesAutocompleteQuery : IRequest<ICollection<CompanySuggestionDTO>?>
    {
        public string? CompanyName { get; set; }
    }
}
