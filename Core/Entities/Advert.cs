using Core.Entities.AdvertDependent;
using Core.Entities.Shared;
using Core.Entities.Shared.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Advert
    {
        public int AdvertID { get; set; }
        public string? AdvertDescription { get; set; }
        public bool CVMandatory { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public TimeOnly WorkTimeFrom { get; set; }
        public TimeOnly WorkTimeTo { get; set; }
        public DateOnly ExpirationDate { get; set; }
        public int ApplicationAmount { get; set; }

        public int CompanyID { get; set; }
        public int PositionID { get; set; }
        public int JobSectorID { get; set; }
        public int SeniorityLevelID { get; set; }
        public int ContractTypeID { get; set; }
        public int EmploymentTypeID { get; set; }
        public int WorkModelID { get; set; }
        public int WorkDaysID { get; set; }

        JobSector JobSector { get; set; } = default!;
        SeniorityLevel SeniorityLevel { get; set; } = default!;
        ContractType ContractType { get; set; } = default!;
        EmploymentType EmploymentType { get; set; } = default!;
        WorkModel WorkModel { get; set; } = default!;
        WorkDays WorkDays { get; set; } = default!;
        Position Position { get; set; } = default!;
        Company Company { get; set; } = default!;

        ICollection<Benefit> Benefits { get; set; } = new List<Benefit>();
        ICollection<Requirment> Requirments { get; set; } = new List<Requirment>();
        ICollection<AdvertDuty> AdvertDuties { get; set; } = new List<AdvertDuty>();
    }
}
