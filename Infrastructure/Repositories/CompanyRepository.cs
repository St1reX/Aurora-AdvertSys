using Core.Entities.Shared.Company;
using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AuroraDbContext dbContext;

        public CompanyRepository(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ICollection<Company>?> GetAllCompanies()
        {
            var companies = await dbContext.Company
                .Include(x => x.CompanyAddress)
                .ToListAsync();

            return companies;
        }

        public async Task<Company?> GetCompanyById(int companyID)
        {
            var company = await dbContext.Company
                .Include(x => x.CompanyAddress)
                .FirstOrDefaultAsync(x => x.CompanyID == companyID);

            return company;
        }
    }
}
