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
    public class UserLanguageConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Language.UserLanguage>
    {
        public void Configure(EntityTypeBuilder<UserLanguage> builder)
        {
            builder.HasKey(x => x.UserLanguageID);
            builder.Property(x => x.LanguageID).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.LanguageLevelID).IsRequired();

            builder.HasOne(x => x.Language)
                .WithMany(y => y.UserLanguages)
                .HasForeignKey(x => x.LanguageID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.LanguageLevel)
                .WithMany(y => y.UserLanguages)
                .HasForeignKey(x => x.LanguageLevelID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
