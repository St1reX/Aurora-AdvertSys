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
    public class RequirmentConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.Requirment>
    {
        public void Configure(EntityTypeBuilder<Requirment> builder)
        {
            builder.HasKey(x => x.RequirmentID);
            builder.Property(x => x.RequirmentDescription).IsRequired().HasMaxLength(50);
        }
    }
}
