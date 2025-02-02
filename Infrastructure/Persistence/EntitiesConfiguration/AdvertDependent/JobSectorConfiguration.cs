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
    public class JobSectorConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.JobSector>
    {
        public void Configure(EntityTypeBuilder<JobSector> builder)
        {
            builder.HasKey(x => x.JobSectorID);
            builder.Property(x => x.JobSectorName).IsRequired().HasMaxLength(50);
        }
    }
}
