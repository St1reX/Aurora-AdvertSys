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
    public class LinkConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.HasKey(x => x.LinkID);
            builder.Property(x => x.URL).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
        }
    }
}
