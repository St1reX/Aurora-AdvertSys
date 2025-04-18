﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Skill
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string SkillName { get; set; } = default!;

        public ICollection<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
    }
}
