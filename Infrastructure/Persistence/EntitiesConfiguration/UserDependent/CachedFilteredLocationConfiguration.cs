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
    public class CachedFilteredLocationConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.CachedFilteredLocation>
    {
        public void Configure(EntityTypeBuilder<CachedFilteredLocation> builder)
        {
            builder.HasKey(x => x.CachedLocationID);

            builder.HasOne(x => x.CachedAdress)
                .WithMany(y => y.CachedFilteredLocations)
                .HasForeignKey(x => x.CachedAdressID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
