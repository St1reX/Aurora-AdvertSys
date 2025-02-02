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
        public int UserID { get; set; }
        public int SkillID { get; set; }
        public int SkillLevel { get; set; }
    }
}
