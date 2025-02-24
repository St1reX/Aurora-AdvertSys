using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.Advert.DTOs
{
    public class AdvertDTO
    {
        public int AdvertID { get; set; }
        public bool CVMandatory { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string WorkTime { get; set; } = default!;
        public DateOnly ExpirationDate { get; set; }
        public string CompanyName { get; set; } = default!;
        public string PositionName { get; set; } = default!;
        public string SeniorityLevelName { get; set; } = default!;

    }
}
