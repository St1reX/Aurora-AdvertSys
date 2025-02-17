using Core.Entities.AdvertDependent;
using Core.Entities.Shared;
using Core.Entities.Shared.Company;

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
        public int AdvertAdressID { get; set; }


        public Position Position { get; set; } = default!;
        public Company Company { get; set; } = default!;
        public JobSector JobSector { get; set; } = default!;
        public SeniorityLevel SeniorityLevel { get; set; } = default!;
        public ContractType ContractType { get; set; } = default!;
        public EmploymentType EmploymentType { get; set; } = default!;
        public WorkModel WorkModel { get; set; } = default!;
        public WorkDays WorkDays { get; set; } = default!;
        public Address AdvertAdress { get; set; } = default!;

        public ICollection<Benefit> Benefits { get; set; } = new List<Benefit>();
        public ICollection<Requirment> Requirments { get; set; } = new List<Requirment>();
        public ICollection<AdvertDuty> AdvertDuties { get; set; } = new List<AdvertDuty>();
    }
}
