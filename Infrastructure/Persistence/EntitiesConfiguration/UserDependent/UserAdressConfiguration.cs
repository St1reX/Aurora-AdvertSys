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
    public class UserAdressConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.UserAdress>
    {
        public void Configure(EntityTypeBuilder<UserAdress> builder)
        {
            builder.HasKey(x => x.UserAdressID);
            builder.Property(x => x.StreetNumber).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Street).IsRequired().HasMaxLength(50);
            builder.Property(x => x.City).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Region).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(50);
            builder.Property(x => x.UserID).IsRequired();
        }
    }
}
