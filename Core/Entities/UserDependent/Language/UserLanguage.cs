using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Language
{
    public class UserLanguage
    {
        public int UserLanguageID { get; set; }
        public int LanguageID { get; set; } = default!;
        public int LanguageLevelID { get; set; } = default!;
        public int UserID { get; set; }

        public Language Language { get; set; } = default!;
        public LanguageLevel LanguageLevel { get; set; } = default!;
        public User User { get; set; } = default!;
    }
}
