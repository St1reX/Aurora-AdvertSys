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
    public class WorkModelRepository : IWorkModelRepository
    {
        private readonly AuroraDbContext dbContext;

        public WorkModelRepository(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<WorkModel>?> GetAllWorkModels()
        {
            var workModels = await dbContext.WorkModel
                .ToListAsync();

            return workModels;
        }
    }
}
