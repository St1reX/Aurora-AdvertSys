using Core.Entities.AdvertDependent;

namespace Core.Interfaces
{
    public interface IEmploymentTypeRepository
    {
        Task<IEnumerable<EmploymentType>?> GetAllEmploymentTypes();
    }
}
