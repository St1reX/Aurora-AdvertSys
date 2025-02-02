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
    public class EmploymentTypeConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.EmploymentType>
    {
        public void Configure(EntityTypeBuilder<EmploymentType> builder)
        {
            builder.HasKey(x => x.EmploymentTypeID);
            builder.Property(x => x.EmploymentTypeName).IsRequired().HasMaxLength(50);
        }
    }
}
