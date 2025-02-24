using Core.Entities.AdvertDependent;

namespace Core.Interfaces.AdvertDependent
{
    public interface IWorkModelRepository
    {
        Task<IEnumerable<WorkModel>?> GetAllWorkModels();
    }
}
