﻿using Core.Entities.AdvertDependent;
using Core.Entities.Shared;
using Core.Entities.Shared.Company;
using Core.Entities.UserDependent;
using Core.Entities.UserDependent.Education;
using Core.Entities.UserDependent.Experience;
using Core.Entities.UserDependent.Language;
using Core.Entities.UserDependent.Skill;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string? ProfilePicturePath { get; set; }
        public string? CVPath { get; set; }
        public string? WorkSummary { get; set; }

        public int? PositionID { get; set; }
        public int? CompanyID { get; set; }
        public int UserAddressID { get; set; }

        public Position? Position { get; set; }
        public Company? Company { get; set; }
        public Address UserAddress { get; set; } = default!;

        public ICollection<UserLanguage> UserLanguages { get; set; } = new List<UserLanguage>();
        public ICollection<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
        public ICollection<Link> Links { get; set; } = new List<Link>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Education> Educations { get; set; } = new List<Education>();
        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();
        public ICollection<AdvertApplication> AdvertApplications { get; set; } = new List<AdvertApplication>();
    }
}
