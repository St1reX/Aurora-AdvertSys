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
                    CompanyID = 1
                };

                dbContext.User.Add(defaultUser);
            }

            //TODO: Rethink problem with FK keys when seeding

            await dbContext.SaveChangesAsync();
        }
    }
}
