using Core.Entities.Shared;
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

        public async Task Create(int addressID)
        {
            var cachedAddress = new CachedAddress
            {
                AddressID = addressID
            };

            dbContext.CachedAddress.Add(cachedAddress);
            await dbContext.SaveChangesAsync();
        }

        public Task<CachedAddress> GetAddressByID(int addressID)
        {
            throw new NotImplementedException();
        }
    }
}
