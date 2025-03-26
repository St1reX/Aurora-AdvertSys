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
    public class AdvertConfiguration : IEntityTypeConfiguration<Core.Entities.Advert>
    {
        public void Configure(EntityTypeBuilder<Advert> builder)
        {
            builder.HasKey(x => x.AdvertID);
            builder.Property(x => x.AdvertDescription).IsRequired().HasMaxLength(500);
            builder.Property(x => x.CVMandatory).IsRequired();
            builder.Property(x => x.MinSalary).IsRequired().HasPrecision(7, 2);
            builder.Property(x => x.MaxSalary).IsRequired().HasPrecision(7, 2);
            builder.Property(x => x.WorkTimeFrom).IsRequired();
            builder.Property(x => x.WorkTimeTo).IsRequired();
            builder.Property(x => x.ExpirationDate).IsRequired();
            builder.Property(x => x.ApplicationAmount).IsRequired();
            builder.Property(x => x.CompanyID).IsRequired();
            builder.Property(x => x.PositionID).IsRequired();
            builder.Property(x => x.JobSectorID).IsRequired();
            builder.Property(x => x.SeniorityLevelID).IsRequired();
            builder.Property(x => x.ContractTypeID).IsRequired();
            builder.Property(x => x.EmploymentTypeID).IsRequired();
            builder.Property(x => x.WorkModelID).IsRequired();
            builder.Property(x => x.WorkDaysID).IsRequired();

            builder.HasOne(x => x.JobSector)
                .WithMany(y => y.Adverts)
                .HasForeignKey(x => x.JobSectorID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.SeniorityLevel)
                .WithMany(y => y.Adverts)
                .HasForeignKey(x => x.SeniorityLevelID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ContractType)
                .WithMany(y => y.Adverts)
                .HasForeignKey(x => x.ContractTypeID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.EmploymentType)
                .WithMany(y => y.Adverts)
                .HasForeignKey(x => x.EmploymentTypeID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.WorkModel)
                .WithMany(y => y.Adverts)
                .HasForeignKey(x => x.WorkModelID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.WorkDays)
                .WithMany(y => y.Adverts)
                .HasForeignKey(x => x.WorkDaysID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Position)
                .WithMany(y => y.Adverts)
                .HasForeignKey(x => x.PositionID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Company)
                .WithMany(y => y.Adverts)
                .HasForeignKey(x => x.CompanyID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.AdvertAddress)
                .WithMany(y => y.Adverts)
                .HasForeignKey(x => x.AdvertAddressID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
