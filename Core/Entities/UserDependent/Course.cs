using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; } = default!;
        public string Organizer { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int UserID { get; set; }

        public User User { get; set; } = default!;
    }
}
