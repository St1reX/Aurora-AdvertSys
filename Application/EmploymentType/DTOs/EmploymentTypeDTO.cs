using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmploymentType.DTOs
{
    public class EmploymentTypeDTO
    {
        public int EmploymentTypeID { get; set; }
        public string EmploymentTypeName { get; set; } = default!;
    }
}
