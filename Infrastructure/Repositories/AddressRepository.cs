using Core.Entities.Shared;
using Core.Interfaces;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AddressRepository : IAddress
    {
        private readonly AuroraDbContext dbContext;

        public AddressRepository(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Address> GetByAddressID(int id)
        {
            var adress = await dbContext.Address.FindAsync(id);
            return adress!;
        }

        public async Task SaveAdress(Address address)
        {
            await dbContext.Address.AddAsync(address);
            await dbContext.SaveChangesAsync();
        }
    }
}
