﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Language
{
    public class Language
    {
        public int LanguageID { get; set; }
        public string LanguageName { get; set; } = default!;

        public ICollection<UserLanguage> UserLanguages { get; set; } = new List<UserLanguage>();
    }
}
