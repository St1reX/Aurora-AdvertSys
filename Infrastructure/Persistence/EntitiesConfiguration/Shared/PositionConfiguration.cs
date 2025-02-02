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
    public class PositionConfiguration : IEntityTypeConfiguration<Core.Entities.Shared.Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(x => x.PositionID);
            builder.Property(x => x.PositionName).IsRequired().HasMaxLength(50);
        }
    }
}
