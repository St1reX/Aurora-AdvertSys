using Core.Entities.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.Shared
{
    internal class AddressConfiguration : IEntityTypeConfiguration<Core.Entities.Shared.Address>
    {

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.AdressID);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(50);
        }
    }
}
