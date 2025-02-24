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
    public class ContractTypeRepository : IContractTypeRepository
    {
        private readonly AuroraDbContext dbContext;

        public ContractTypeRepository(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ContractType>?> GetAllContractTypes()
        {
            var contractTypes = await dbContext.ContractType
                .ToListAsync();
            return contractTypes;
        }
    }
}
