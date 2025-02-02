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
    public class ContractTypeConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.ContractType>
    {
        public void Configure(EntityTypeBuilder<ContractType> builder)
        {
            builder.HasKey(x => x.ContractTypeID);
            builder.Property(x => x.ContractTypeName).IsRequired().HasMaxLength(50);
        }
    }
}
