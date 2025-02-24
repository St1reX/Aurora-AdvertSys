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
    public class JobSectorRepository : IJobSectorRepository
    {
        private readonly AuroraDbContext dbContext;

        public JobSectorRepository(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<JobSector>?> GetAllJobSectors()
        {
            var jobSectors = await dbContext.JobSector
                .ToListAsync();
            return jobSectors;
        }
    }
}
