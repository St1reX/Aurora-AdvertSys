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
    public class WorkModelConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.WorkModel>
    {
        public void Configure(EntityTypeBuilder<WorkModel> builder)
        {
            builder.HasKey(x => x.WorkModelID);
            builder.Property(x => x.WorkModelName).IsRequired().HasMaxLength(50);
        }
    }
}
