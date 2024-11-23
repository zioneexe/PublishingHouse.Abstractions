using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface ICustomerTypeRepository
{
    Task<List<ICustomerType>> GetAllAsync();
    Task<ICustomerType?> GetByIdAsync(int id);
    Task<ICustomerType> AddAsync(ICustomerType customerType);
    Task<ICustomerType?> UpdateAsync(int id, ICustomerType customerType);
    Task<ICustomerType?> DeleteAsync(int id);
}