using Core.Entities.AdvertDependent;

namespace Core.Interfaces
{
    public interface IWorkModelRepository
    {
        Task<IEnumerable<WorkModel>?> GetAllWorkModels();
    }
}
