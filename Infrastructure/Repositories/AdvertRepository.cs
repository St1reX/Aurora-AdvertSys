using Core.Entities;
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
    internal class AdvertRepository : IAdvert
    {
        private readonly AuroraDbContext dbContext;

        public AdvertRepository(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<Advert>?> GetAll()
        {
            var adverts = await dbContext.Advert
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.SeniorityLevel)
                .ToListAsync();

            return adverts;
        }

        public async Task<ICollection<Advert>?> GetRange(int amount, int offset)
        {
            var adverts = await dbContext.Advert
                .Include(x => x.Company)
                .Include(x => x.Position)
                .Include(x => x.SeniorityLevel)
                .Skip(offset)
                .Take(amount)
                .ToListAsync();

            return adverts;
        }
    }
}
