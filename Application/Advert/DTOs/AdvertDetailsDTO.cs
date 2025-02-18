using Application.Adress.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.DTOs
{
    public class AdvertDetailsDTO
    {
        public int AdvertID { get; set; }
        public string Description { get; set; } = default!;
        public bool CVMandatory { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string WorkTime { get; set; } = default!;
        public DateOnly ExpirationDate { get; set; }
        public string CompanyName { get; set; } = default!;
        public string PositionName { get; set; } = default!;
        public string JobSectorName { get; set; } = default!;
        public string SeniorityLevelName { get; set; } = default!;
        public string ContractTypeName { get; set; } = default!;
        public string EmploymentTypeName { get; set; } = default!;
        public string WorkModelName { get; set; } = default!;
        public string WorkDaysName { get; set; } = default!;

        public AddressDTO Address { get; set; } = default!;
    }
}
