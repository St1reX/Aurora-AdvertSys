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
    public class WorkDaysConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.WorkDays>
    {
        public void Configure(EntityTypeBuilder<WorkDays> builder)
        {
            builder.HasKey(x => x.WorkDaysID);
            builder.Property(x => x.WorkDaysName).IsRequired().HasMaxLength(50);
        }
    }
}
