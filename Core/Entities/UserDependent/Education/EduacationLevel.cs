using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Education
{
    public class EduacationLevel
    {
        public int EduacationLevelID { get; set; }
        public string Level { get; set; } = default!;
    }
}
