using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Experience
{
    public class Experience
    {
        public int ExperienceID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int PositionID { get; set; }
        public int CompanyID { get; set; }
        public int UserID { get; set; }
    }
}
