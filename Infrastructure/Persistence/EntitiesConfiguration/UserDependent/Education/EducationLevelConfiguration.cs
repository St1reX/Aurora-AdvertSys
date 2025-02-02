using Core.Entities.UserDependent.Education;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent.Education
{
    public class EducationLevelConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Education.EducationLevel>
    {
        public void Configure(EntityTypeBuilder<EducationLevel> builder)
        {
            builder.HasKey(e => e.EducationLevelID);
            builder.Property(e => e.Level).IsRequired().HasMaxLength(30);
        }
    }
}
