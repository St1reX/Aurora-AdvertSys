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
    public class AdvertDutyConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.AdvertDuty>
    {
        public void Configure(EntityTypeBuilder<AdvertDuty> builder)
        {
            builder.HasKey(x => x.AdvertDutyID);
            builder.Property(x => x.DutyID).IsRequired();
            builder.Property(x => x.AdvertID).IsRequired();
        }
    }
}
