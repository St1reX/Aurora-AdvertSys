using Core.Entities.AdvertDependent;

namespace Core.Interfaces.AdvertDependent
{
    public interface IJobSectorRepository
    {
        Task<IEnumerable<JobSector>?> GetAllJobSectors();
    }
}
