using Core.Entities.UserDependent.Experience;

namespace Core.Entities.Shared.Company
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Website { get; set; } = default!;


        public int CompanyAddressID { get; set; }
        public Address CompanyAddress { get; set; } = default!;


        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();
    }
}
