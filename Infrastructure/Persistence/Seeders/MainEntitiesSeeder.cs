﻿using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeders
{
    public class MainEntitiesSeeder
    {
        private readonly AuroraDbContext dbContext;

        public MainEntitiesSeeder(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Seed()
        {

            if (!dbContext.Advert.Any())
            {
                var defaultAdvert = new Core.Entities.Advert()
                {
                    AdvertDescription = "We are looking for a software developer",
                    CVMandatory = true,
                    MinSalary = 5000,
                    MaxSalary = 10000,
                    WorkTimeFrom = new TimeOnly(8, 0),
                    WorkTimeTo = new TimeOnly(16, 0),
                    ExpirationDate = new DateOnly(2022, 12, 31),
                    ApplicationAmount = 10,
                    CompanyID = 1,
                    PositionID = 1,
                    JobSectorID = 1,
                    SeniorityLevelID = 1,
                    ContractTypeID = 1,
                    EmploymentTypeID = 1,
                    WorkModelID = 1,
                    WorkDaysID = 1,
                    AdvertAddressID = 1
                };
                dbContext.Advert.Add(defaultAdvert);


                //Placed here because advert is needed to be seeded first
                var defaultAdvertApplication = new Core.Entities.AdvertDependent.AdvertApplication()
                {
                    AdvertID = 1,
                    UserID = "1",
                    ApplicationDate = DateTime.Now,
                    IsAccepted = false,
                    IsRejected = false,
                    IsPending = true
                };

                await dbContext.SaveChangesAsync();
            }
        }
    }
}
