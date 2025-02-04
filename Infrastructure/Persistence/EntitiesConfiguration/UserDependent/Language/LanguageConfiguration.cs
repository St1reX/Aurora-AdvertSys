using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent.Language
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Language.Language>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.UserDependent.Language.Language> builder)
        {
            builder.HasKey(x => x.LanguageID);
            builder.Property(x => x.LanguageName).IsRequired().HasMaxLength(30);
        }
    }
}
