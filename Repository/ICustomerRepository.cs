using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface ICustomerRepository
{
    Task<List<ICustomer>> GetAllAsync();
    Task<ICustomer?> GetByIdAsync(int id);
    Task<List<ICustomer>> GetByCustomerTypeIdAsync(int customerTypeId);
    Task<ICustomer> AddAsync(ICustomer customer);
    Task<ICustomer?> UpdateAsync(int id, ICustomer customer);
    Task<ICustomer?> DeleteAsync(int id);
}