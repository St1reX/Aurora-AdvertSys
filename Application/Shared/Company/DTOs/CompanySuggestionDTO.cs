﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.Company.DTOs
{
    public class CompanySuggestionDTO
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; } = default!;
    }
}
