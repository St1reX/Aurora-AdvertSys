﻿using Core.Entities.Shared.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICompanyRepository
    {
        Task<ICollection<Company>?> GetAllCompanies();
        Task<Company?> GetCompanyById(int companyID);
        Task<ICollection<Company>?> GetCompaniesAutocomplete(string companyName);
    }
}
