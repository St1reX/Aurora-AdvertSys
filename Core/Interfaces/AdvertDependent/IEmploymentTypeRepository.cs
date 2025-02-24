using Core.Entities.AdvertDependent;

namespace Core.Interfaces.AdvertDependent
{
    public interface IEmploymentTypeRepository
    {
        Task<IEnumerable<EmploymentType>?> GetAllEmploymentTypes();
    }
}
