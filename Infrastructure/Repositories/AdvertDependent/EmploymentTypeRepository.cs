using Core.Entities.AdvertDependent;
using Core.Interfaces.AdvertDependent;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.AdvertDependent
{
    public class EmploymentTypeRepository : IEmploymentTypeRepository
    {
        private readonly AuroraDbContext dbContext;

        public EmploymentTypeRepository(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<EmploymentType>?> GetAllEmploymentTypes()
        {
            var employmentTypes = await dbContext.EmploymentType
                .ToListAsync();
            return employmentTypes;
        }
    }
}
