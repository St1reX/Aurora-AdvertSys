using Core.Entities.AdvertDependent;

namespace Core.Interfaces.AdvertDependent
{
    public interface ISeniorityLevelRepository
    {
        Task<IEnumerable<SeniorityLevel>?> GetAllSeniorityLevels();
    }
}
