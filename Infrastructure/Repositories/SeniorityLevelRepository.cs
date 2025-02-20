using Core.Entities.AdvertDependent;
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
    public class SeniorityLevelRepository : ISeniorityLevelRepository
    {
        private readonly AuroraDbContext dbContext;

        public SeniorityLevelRepository(AuroraDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SeniorityLevel>?> GetAllSeniorityLevels()
        {
            var seniorityLevels = await dbContext.SeniorityLevel
                .ToListAsync();

            return seniorityLevels;
        }
    }
}
