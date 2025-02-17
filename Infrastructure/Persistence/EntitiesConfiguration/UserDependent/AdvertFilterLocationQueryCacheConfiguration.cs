using Core.Entities.UserDependent;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent
{
    public class AdvertFilterLocationQueryCacheConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.FilteredLocationsCache>
    {
        public void Configure(EntityTypeBuilder<FilteredLocationsCache> builder)
        {
            builder.HasKey(x => x.LocationCacheID);
            builder.Property(x => x.Location).IsRequired();
            builder.Property(x => x.Latitude).IsRequired();
            builder.Property(x => x.Longitude).IsRequired();
        }
    }
}
