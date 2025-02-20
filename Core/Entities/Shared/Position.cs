using Core.Entities.UserDependent.Experience;

namespace Core.Entities.Shared
{
    public class Position
    {
        public int PositionID { get; set; }
        public string PositionName { get; set; } = default!;

        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();

        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
