using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent.Education
{
    public class EducationConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Education.Education>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.UserDependent.Education.Education> builder)
        {
            builder.HasKey(e => e.EducationID);
            builder.Property(e => e.SchoolName).IsRequired().HasMaxLength(60);
            builder.Property(e => e.City).IsRequired().HasMaxLength(30);
            builder.Property(e => e.FieldOfStudy).IsRequired().HasMaxLength(30);
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired();
            builder.Property(e => e.EduacationLevelID).IsRequired();
            builder.Property(e => e.UserID).IsRequired();

        }
    }
}
