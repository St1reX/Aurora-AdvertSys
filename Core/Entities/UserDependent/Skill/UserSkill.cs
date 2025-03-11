using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Skill
{
    public class UserSkill
    {
        public int UserSkillID { get; set; }
        public string UserID { get; set; } = default!;
        public int SkillID { get; set; }
        public int SkillLevel { get; set; }

        public ApplicationUser User { get; set; } = default!;
        public Skill Skill { get; set; } = default!;
    }
}
