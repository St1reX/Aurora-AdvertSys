using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<Core.Entities.User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserID);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.ProfilePicturePath).HasMaxLength(255);
            builder.Property(x => x.CVPath).HasMaxLength(255);
            builder.Property(x => x.WorkSummary).HasMaxLength(500);
            builder.Property(x => x.PositionID).IsRequired();

            builder.HasOne(x => x.Position)
                .WithMany(y => y.Users)
                .HasForeignKey(x => x.PositionID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Company)
                .WithMany(y => y.Users)
                .HasForeignKey(x => x.CompanyID)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.UserAdress)
                .WithMany(y => y.Users)
                .HasForeignKey(x => x.UserAdressID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
