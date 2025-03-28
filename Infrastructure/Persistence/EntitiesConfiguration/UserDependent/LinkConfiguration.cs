using Core.Entities.UserDependent;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent
{
    public class LinkConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Link>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.UserDependent.Link> builder)
        {
            builder.HasKey(x => x.LinkID);
            builder.Property(x => x.URL).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
        }
    }
}
