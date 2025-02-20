using Core.Entities.AdvertDependent;

namespace Core.Interfaces
{
    public interface IJobSectorRepository
    {
        Task<IEnumerable<JobSector>?> GetAllJobSectors();
    }
}
