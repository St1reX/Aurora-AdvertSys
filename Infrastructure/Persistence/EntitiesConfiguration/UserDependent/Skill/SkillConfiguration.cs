using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent.Skill
{
    public class SkillConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Skill.Skill>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.UserDependent.Skill.Skill> builder)
        {
            builder.HasKey(x => x.SkillID);
            builder.Property(x => x.SkillName).IsRequired().HasMaxLength(30);
        }
    }
}
