using Core.Entities.UserDependent;
using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CachedAddressRepository : ICachedAddress
    {
        private readonly AuroraDbContext dbContext;

        public CachedAddressRepository(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(string addressID)
        {
            var cachedAddress = new CachedAddress
            dbContext.CachedAddress.Add();
        }
    }
}
