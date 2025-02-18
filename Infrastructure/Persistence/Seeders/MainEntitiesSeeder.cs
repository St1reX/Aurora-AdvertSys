using Infrastructure.Persistence;
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
            if (!dbContext.User.Any())
            {
                var defaultUser = new Core.Entities.User()
                {
                    FirstName = "Jakub",
                    LastName = "Uryga",
                    Email = "urygajakub@gmail.com",
                    Password = "SAMPLEHASHEDPASSWORD",
                    ProfilePicturePath = "profile.jpg",
                    CVPath = "cv.pdf",
                    WorkSummary = "I am a software developer",
                    PositionID = 1,
                    CompanyID = 1,
                    UserAddressID = 1
                };

                dbContext.User.Add(defaultUser);
            }

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

                //TODO: Rethink problem with FK keys when seeding

                await dbContext.SaveChangesAsync();
            }
        }
    }
}
