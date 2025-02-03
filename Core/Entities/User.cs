using Core.Entities.AdvertDependent;
using Core.Entities.Shared;
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
        public string ProfilePicturePath { get; set; } = default!;
        public string CVPath { get; set; } = default!;
        public string WorkSummary { get; set; } = default!;

        public int PositionID { get; set; }
        public int? CompanyID { get; set; }

        public Position Position { get; set; } = default!;
        public Company? Company { get; set; }

        public ICollection<UserLanguage> UserLanguages { get; set; } = new List<UserLanguage>();
        public ICollection<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
        public ICollection<Link> Links { get; set; } = new List<Link>();
        public ICollection<UserAdress> UserAdresses { get; set; } = new List<UserAdress>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Education> Educations { get; set; } = new List<Education>();
        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
