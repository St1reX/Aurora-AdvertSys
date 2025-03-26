using Core.Entities.AdvertDependent;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.AdvertDependent
{
    public class AdvertApplicationConfiguration
    {
        public void Configure(EntityTypeBuilder<AdvertApplication> builder)
        {
            builder.HasKey(x => x.AdvertApplicationID);
            builder.Property(x => x.AdvertID).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.ApplicationDate).IsRequired();
            builder.Property(x => x.IsAccepted).IsRequired();
            builder.Property(x => x.IsRejected).IsRequired();
            builder.Property(x => x.IsPending).IsRequired();

        }
    }
}
