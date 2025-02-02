using Core.Entities.UserDependent.Skill;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntitiesConfiguration.UserDependent.Skill
{
    public class UserSkillConfiguration : IEntityTypeConfiguration<Core.Entities.UserDependent.Skill.UserSkill>
    {
        public void Configure(EntityTypeBuilder<UserSkill> builder)
        {
            builder.HasKey(x => x.UserSkillID);
            builder.Property(x => x.SkillID).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.SkillLevel).IsRequired().HasMaxLength(15);
        }
    }
}
