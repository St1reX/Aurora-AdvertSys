using Core.Entities.UserDependent;

namespace Core.Entities.Shared
{
    public class Address
    {
        public int AdressID { get; set; }
        public string? StreetNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; } = default!;
        public string? Region { get; set; }
        public string Country { get; set; } = default!;
        public string Latitude { get; set; } = default!;
        public string Longitude { get; set; } = default!;


        public ICollection<Company.Company> Companies { get; set; } = new List<Company.Company>();
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();
        public ICollection<CachedFilteredLocation> CachedFilteredLocations { get; set; } = new List<CachedFilteredLocation>();
    }
}
