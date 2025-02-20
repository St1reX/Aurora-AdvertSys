using Core.Entities.AdvertDependent;

namespace Core.Interfaces
{
    public interface ISeniorityLevelRepository
    {
        Task<IEnumerable<SeniorityLevel>?> GetAllSeniorityLevels();
    }
}
