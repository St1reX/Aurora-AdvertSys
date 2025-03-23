using Core.Entities.AdvertDependent;
using Core.Entities.Shared.Company;
using Core.Entities.Shared;
using Core.Entities.UserDependent.Education;
using Core.Entities.UserDependent.Language;
using Core.Entities.UserDependent.Skill;
using Core.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence.Seeders
{
    public class AuroraBasicSeeder
    {
        private readonly AuroraDbContext dbContext;
        private readonly RoleManager<IdentityRole> roleManager;

        public AuroraBasicSeeder(AuroraDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            this.dbContext = dbContext;
            this.roleManager = roleManager;
        }
        public async Task Seed()
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                if(!dbContext.Advert.Any())
                {
                    await new SharedSeeder(dbContext).Seed();
                    await new UserDependentSeeder(dbContext).Seed();
                    await new AdvertDependentSeeder(dbContext).Seed();
                    await new MainEntitiesSeeder(dbContext).Seed();
                    await new IdentitySeeder(dbContext, roleManager).Seed();
                }
                else
                {
                    Console.WriteLine("Already seeded. Skipping process...");
                }
                
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
