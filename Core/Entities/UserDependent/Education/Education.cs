﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserDependent.Education
{
    public class Education
    {
        public int EducationID { get; set; }
        public string SchoolName { get; set; } = default!;
        public string City { get; set; } = default!;
        public string FieldOfStudy { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EducationLevelID { get; set; }
        public string UserID { get; set; } = default!;

        public EducationLevel EducationLevel { get; set; } = default!;
        public ApplicationUser User { get; set; } = default!;
    }
}
