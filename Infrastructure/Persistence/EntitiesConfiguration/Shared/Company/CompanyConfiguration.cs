﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.Shared.Company
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Core.Entities.Shared.Company.Company>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Shared.Company.Company> builder)
        {
            builder.HasKey(x => x.CompanyID);
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Website).IsRequired();

            builder.HasOne(x => x.CompanyAdress)
                .WithMany(y => y.Companies)
                .HasForeignKey(x => x.CompanyAdressID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
