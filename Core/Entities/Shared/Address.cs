namespace Core.Entities.Shared
{
    public class Address
    {
        public int AddressID { get; set; }
        public string? StreetNumber { get; set; }
        public string? Street { get; set; }
        public string City { get; set; } = default!;
        public string? Region { get; set; }
        public string Country { get; set; } = default!;
        public decimal Latitude { get; set; } = 0;
        public decimal Longitude { get; set; } = 0;


        public ICollection<Company.Company> Companies { get; set; } = new List<Company.Company>();
        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();
    }
}
