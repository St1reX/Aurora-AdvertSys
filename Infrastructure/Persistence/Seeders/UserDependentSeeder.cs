using Core.Entities.Shared.Company;
using Core.Entities.Shared;
using Core.Entities.UserDependent.Education;
using Core.Entities.UserDependent.Language;
using Core.Entities.UserDependent.Skill;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeders
{
    public class UserDependentSeeder
    {
        private readonly AuroraDbContext dbContext;

        public UserDependentSeeder(AuroraDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Seed()
        {

            if (!dbContext.EducationLevel.Any())
            {
                var defaultEducationLevel = new EducationLevel()
                {
                    Level = "Engineer"
                };
                dbContext.EducationLevel.Add(defaultEducationLevel);
            }

            if (!dbContext.Language.Any())
            {
                var defaultLanguage = new Language()
                {
                    LanguageName = "English"
                };
                dbContext.Language.Add(defaultLanguage);
            }

            if (!dbContext.LanguageLevel.Any())
            {
                var defaultLanguageLevel = new LanguageLevel()
                {
                    Level = "B2"
                };
                dbContext.LanguageLevel.Add(defaultLanguageLevel);
            }

            if (!dbContext.Skill.Any())
            {
                var defaultSkill = new Skill()
                {
                    SkillName = "C#"
                };
                dbContext.Skill.Add(defaultSkill);
            }



            await dbContext.SaveChangesAsync();
        }
    }
}
