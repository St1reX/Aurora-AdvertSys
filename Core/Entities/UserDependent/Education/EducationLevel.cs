using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Education
{
    public class EducationLevel
    {
        public int EducationLevelID { get; set; }
        public string Level { get; set; } = default!;

        public ICollection<Education> Educations { get; set; } = new List<Education>();
    }
}
