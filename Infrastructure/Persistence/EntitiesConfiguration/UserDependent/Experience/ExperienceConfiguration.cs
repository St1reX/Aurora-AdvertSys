using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent.Experience
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Experience.Experience>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.UserDependent.Experience.Experience> builder)
        {
            builder.HasKey(x => x.ExperienceID);
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.CompanyID).IsRequired();
        }
    }
}
