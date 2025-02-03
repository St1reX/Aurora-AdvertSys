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
    public class BenefitConfiguration : IEntityTypeConfiguration<Core.Entities.AdvertDependent.Benefit>
    {
        public void Configure(EntityTypeBuilder<Benefit> builder)
        {
            builder.HasKey(x => x.BenefitID);
            builder.Property(x => x.BenefitDescription).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AdvertID).IsRequired();

            builder.HasOne(x => x.Advert)
                .WithMany(y => y.Benefits)
                .HasForeignKey(x => x.AdvertID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
