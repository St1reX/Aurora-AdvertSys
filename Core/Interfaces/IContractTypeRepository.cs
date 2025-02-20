using Core.Entities.AdvertDependent;

namespace Core.Interfaces
{
    public interface IContractTypeRepository
    {
        Task<IEnumerable<ContractType>?> GetAllContractTypes();
    }
}
