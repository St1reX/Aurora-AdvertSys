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
    public class AdvertExposuresConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.AdvertExposures>
    {
        public void Configure(EntityTypeBuilder<AdvertExposures> builder)
        {
            builder.HasKey(x => x.AdvertExposuresID);

            builder.Property(x => x.ExposureAmount).IsRequired();
            builder.Property(x => x.ExposureDate).IsRequired();
            builder.Property(x => x.AdvertID).IsRequired();
        }
    }
}
