using Core.Entities.AdvertDependent;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.AdvertDependent
{
    public class SeniorityLevelConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.SeniorityLevel>
    {
        public void Configure(EntityTypeBuilder<SeniorityLevel> builder)
        {
            builder.HasKey(x => x.SeniorityLevelID);
            builder.Property(x => x.SeniorityLevelName).IsRequired().HasMaxLength(50);
        }
    }
}
