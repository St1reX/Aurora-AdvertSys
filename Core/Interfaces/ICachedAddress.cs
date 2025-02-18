using Core.Entities.UserDependent;

namespace Core.Interfaces
{
    public interface ICachedAddress
    {
        Task Create(int addressID);
        Task<CachedAddress> GetAddressByID(int addressID);
    }
}
