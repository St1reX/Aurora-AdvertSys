using Core.Entities.Shared.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.Shared.Company
{
    public class CompanyAdressConfiguration : IEntityTypeConfiguration<Core.Entities.Shared.Company.CompanyAdress>
    {
        public void Configure(EntityTypeBuilder<CompanyAdress> builder)
        {
            builder.HasKey(x => x.CompanyAdressID);
            builder.Property(x => x.StreetNumber).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Street).IsRequired().HasMaxLength(50);
            builder.Property(x => x.City).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Region).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CompanyID).IsRequired();
        }
    }
}
