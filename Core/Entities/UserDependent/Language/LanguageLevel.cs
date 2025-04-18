﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Language
{
    public class LanguageLevel
    {
        public int LanguageLevelID { get; set; }
        public string Level { get; set; } = default!;

        public ICollection<UserLanguage> UserLanguages { get; set; } = new List<UserLanguage>();
    }
}
