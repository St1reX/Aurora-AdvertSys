using Core.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.Shared
{
    public class DutyConfiguration : IEntityTypeConfiguration<Core.Entities.Shared.Duty>
    {
        public void Configure(EntityTypeBuilder<Duty> builder)
        {
            builder.HasKey(x => x.DutyID);
            builder.Property(x => x.DutyName).IsRequired().HasMaxLength(255);
        }
    }
}
