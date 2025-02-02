using Core.Entities.UserDependent;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent
{
    public class CourseConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Course>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.CourseID);
            builder.Property(x => x.CourseName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Organizer).IsRequired().HasMaxLength(50);
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
        }
    }
}
