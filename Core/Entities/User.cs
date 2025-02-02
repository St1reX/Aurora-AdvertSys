using Core.Entities.AdvertDependent;
using Core.Entities.Shared.Company;
using Core.Entities.UserDependent;
using Core.Entities.UserDependent.Education;
using Core.Entities.UserDependent.Experience;
using Core.Entities.UserDependent.Language;
using Core.Entities.UserDependent.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string ProfilePicture { get; set; } = default!;
        public string CV { get; set; } = default!;
        public string WorkSummary { get; set; } = default!;

        public int CurrentPositionID { get; set; }
        public int CurrentCompanyID { get; set; }

        public Position CurrentPosition { get; set; } = default!;
        public Company CurrentCompany { get; set; } = default!;

        public ICollection<UserLanguage> UserLanguages { get; set; } = new List<UserLanguage>();
        public ICollection<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
        public ICollection<Link> Links { get; set; } = new List<Link>();
        public ICollection<UserAdress> UserAdresses { get; set; } = new List<UserAdress>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Education> Educations { get; set; } = new List<Education>();
        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
