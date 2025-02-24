using Core.Entities.Shared;

namespace Core.Interfaces.Shared
{
    public interface IPositionRepository
    {
        Task<ICollection<Position>?> GetAllPositions();
        Task<ICollection<Position>?> GetPositionsAutocomplete(string positionName);
    }
}
