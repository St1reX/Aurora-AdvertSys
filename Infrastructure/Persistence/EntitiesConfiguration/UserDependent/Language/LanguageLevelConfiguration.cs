using Core.Entities.UserDependent.Language;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent.Language
{
    public class LanguageLevelConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Language.LanguageLevel>
    {
        public void Configure(EntityTypeBuilder<LanguageLevel> builder)
        {
            builder.HasKey(x => x.LanguageLevelID);
            builder.Property(x => x.Level).IsRequired().HasMaxLength(15);
        }
    }
}
