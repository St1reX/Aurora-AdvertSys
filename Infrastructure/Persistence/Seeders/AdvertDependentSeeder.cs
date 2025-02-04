using Core.Entities.AdvertDependent;
using Core.Entities.Shared;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeders
{
    public class AdvertDependentSeeder
    {
        private readonly AuroraDbContext dbContext;

        public AdvertDependentSeeder(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Seed()
        {

            if (!dbContext.ContractType.Any())
            {
                var defaultContractType = new ContractType()
                {
                    ContractTypeName = "B2B"
                };
                dbContext.ContractType.Add(defaultContractType);
            }

            if (!dbContext.EmploymentType.Any())
            {
                var defaultEmploymentType = new EmploymentType()
                {
                    EmploymentTypeName = "Full-time"
                };
                dbContext.EmploymentType.Add(defaultEmploymentType);
            }

            if (!dbContext.JobSector.Any())
            {
                var defaultJobSector = new JobSector()
                {
                    JobSectorName = "IT"
                };
                dbContext.JobSector.Add(defaultJobSector);
            }

            if (!dbContext.SeniorityLevel.Any())
            {
                var defaultSeniorityLevel = new SeniorityLevel()
                {
                    SeniorityLevelName = "Junior"
                };
                dbContext.SeniorityLevel.Add(defaultSeniorityLevel);
            }

            if (!dbContext.WorkDays.Any())
            {
                var defaultWorkDays = new WorkDays()
                {
                    WorkDaysName = "Monday-Friday"
                };
                dbContext.WorkDays.Add(defaultWorkDays);
            }

            if (!dbContext.WorkModel.Any())
            {
                var defaultWorkModel = new WorkModel()
                {
                    WorkModelName = "Remote"
                };
                dbContext.WorkModel.Add(defaultWorkModel);
            }


            await dbContext.SaveChangesAsync();
        }
    }
}
