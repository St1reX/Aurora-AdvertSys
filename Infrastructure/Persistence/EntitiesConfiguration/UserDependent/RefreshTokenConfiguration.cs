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
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.RefreshToken>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.UserDependent.RefreshToken> builder)
        {
            builder.HasKey(x => x.TokenID);
            builder.Property(x => x.Token).IsRequired().HasMaxLength(200);
            builder.HasIndex(x => x.Token).IsUnique();

            builder.Property(x => x.ExpiryDate).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
        }
    }
}

