﻿using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Persistence
{
    public class AuroraDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuroraDbContext(DbContextOptions<AuroraDbContext> options) : base(options)
        {

        }

        //MAIN ENTITIES
        public DbSet<Core.Entities.Advert> Advert { get; set; }

        //ADVERT DEPENDENT ENTITIES
        public DbSet<Core.Entities.AdvertDependent.AdvertApplication> AdvertApplication { get; set; }
        public DbSet<Core.Entities.AdvertDependent.AdvertExposures> AdvertExposures { get; set; }
        public DbSet<Core.Entities.AdvertDependent.AdvertDuty> AdvertDuty { get; set; }
        public DbSet<Core.Entities.AdvertDependent.Benefit> Benefit { get; set; }
        public DbSet<Core.Entities.AdvertDependent.Requirment> Requirment { get; set; }
        public DbSet<Core.Entities.AdvertDependent.JobSector> JobSector { get; set; }
        public DbSet<Core.Entities.AdvertDependent.SeniorityLevel> SeniorityLevel { get; set; }
        public DbSet<Core.Entities.AdvertDependent.ContractType> ContractType { get; set; }
        public DbSet<Core.Entities.AdvertDependent.EmploymentType> EmploymentType { get; set; }
        public DbSet<Core.Entities.AdvertDependent.WorkModel> WorkModel { get; set; }
        public DbSet<Core.Entities.AdvertDependent.WorkDays> WorkDays { get; set; }

        //SHARED ENTITIES
        public DbSet<Core.Entities.Shared.Position> Position { get; set; }
        public DbSet<Core.Entities.Shared.Duty> Duty { get; set; }
        public DbSet<Core.Entities.Shared.Company.Company> Company { get; set; }
        public DbSet<Core.Entities.Shared.Address> Address { get; set; }

        //USER DEPENDENT ENTITIES
        public DbSet<Core.Entities.UserDependent.RefreshToken> RefreshToken { get; set; }
        public DbSet<Core.Entities.UserDependent.Education.Education> Education { get; set; }
        public DbSet<Core.Entities.UserDependent.Education.EducationLevel> EducationLevel { get; set; }
        public DbSet<Core.Entities.UserDependent.Experience.Experience> Experience { get; set; }
        public DbSet<Core.Entities.UserDependent.Experience.ExperienceDuty> ExperienceDuty { get; set; }
        public DbSet<Core.Entities.UserDependent.Language.Language> Language { get; set; }
        public DbSet<Core.Entities.UserDependent.Language.LanguageLevel> LanguageLevel { get; set; }
        public DbSet<Core.Entities.UserDependent.Language.UserLanguage> UserLanguage { get; set; }
        public DbSet<Core.Entities.UserDependent.Skill.Skill> Skill { get; set; }
        public DbSet<Core.Entities.UserDependent.Skill.UserSkill> UserSkill { get; set; }
        public DbSet<Core.Entities.UserDependent.Course> Course { get; set; }
        public DbSet<Core.Entities.UserDependent.Link> Link { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Apply configurations from all entities
        }
    }
}
