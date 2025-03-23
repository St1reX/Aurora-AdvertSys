using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeders
{
    public class IdentitySeeder
    {
        private readonly AuroraDbContext dbContext;
        private readonly RoleManager<IdentityRole> roleManager;

        public IdentitySeeder(AuroraDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            this.dbContext = dbContext;
            this.roleManager = roleManager;
        }
        public async Task Seed()
        {
            List<string> roles = new List<string>
            {
                "Candidate",
                "Employer",
                "Company Moderator",
                "Premium Employer",
                "Premium Candidate",
                "Admin"
            };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
