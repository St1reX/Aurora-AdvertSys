using Core.Entities.Shared;
using Core.Entities.Shared.Company;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeders
{
    public class SharedSeeder
    {
        private readonly AuroraDbContext dbContext;

        public SharedSeeder(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (!dbContext.Position.Any())
            {
                var defaultPosition = new Position()
                {
                    PositionName = "Software Developer"
                };
                dbContext.Position.Add(defaultPosition);
            }

            if (!dbContext.Duty.Any())
            {
                var defaultDuty = new Duty()
                {
                    DutyName = "Writing complex code in C# ASP.NET technology."
                };
                dbContext.Duty.Add(defaultDuty);
            }

            if (!dbContext.Company.Any())
            {
                var defaultCompany = new Company()
                {
                    CompanyName = "Aurora",
                    Description = "Aurora is a software development company.",
                    Email = "aurora@gmail.com",
                    Website = "aurora.com"
                };
                dbContext.Company.Add(defaultCompany);
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
