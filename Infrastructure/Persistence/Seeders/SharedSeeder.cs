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

            if (!dbContext.Address.Any())
            {
                var defaultAdress = new Address()
                {
                    StreetNumber = "7",
                    Street = "Konopnickiej",
                    City = "Limanowa",
                    Region = "Małopolskie",
                    Country = "Poland",
                    Latitude = 49.708170M,
                    Longitude = 20.422075M
                };
                dbContext.Address.Add(defaultAdress);
            }

            if (!dbContext.Company.Any())
            {
                var defaultCompany = new Company()
                {
                    CompanyName = "Aurora",
                    Description = "Aurora is a software development company.",
                    Email = "aurora@gmail.com",
                    Website = "aurora.com",
                    CompanyAddressID = 1
                };
                dbContext.Company.Add(defaultCompany);
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
