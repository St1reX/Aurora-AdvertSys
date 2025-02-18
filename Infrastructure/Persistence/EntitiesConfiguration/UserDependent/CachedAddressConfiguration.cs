﻿using Core.Entities.UserDependent;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent
{
    public class CachedAddressConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.CachedAddress>
    {
        public void Configure(EntityTypeBuilder<CachedAddress> builder)
        {
            builder.HasKey(x => x.CachedAddressID);

            builder.HasOne(x => x.Address)
                .WithMany(y => y.CachedAddresses)
                .HasForeignKey(x => x.CachedAddressID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
