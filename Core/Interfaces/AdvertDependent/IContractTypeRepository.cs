using Core.Entities.AdvertDependent;

namespace Core.Interfaces.AdvertDependent
{
    public interface IContractTypeRepository
    {
        Task<IEnumerable<ContractType>?> GetAllContractTypes();
    }
}
