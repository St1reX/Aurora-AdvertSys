﻿using Core.Entities.UserDependent.Experience;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent.Experience
{
    public class ExperienceDutyConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Experience.ExperienceDuty>
    {
        public void Configure(EntityTypeBuilder<ExperienceDuty> builder)
        {
            builder.HasKey(x => x.ExperienceDutyID);
            builder.Property(x => x.ExperienceID).IsRequired();
            builder.Property(x => x.DutyID).IsRequired();
        }
    }
}
