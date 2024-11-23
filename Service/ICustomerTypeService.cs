using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface ICustomerTypeService
{
    Task<List<CustomerTypeOutput>> GetAllAsync();
    Task<CustomerTypeOutput?> GetByIdAsync(int id);
    Task<CustomerTypeOutput> AddAsync(CustomerTypeInput customerTypeInput);
    Task<CustomerTypeOutput?> UpdateAsync(int id, CustomerTypeInput customerTypeInput);
    Task<CustomerTypeOutput?> DeleteAsync(int id);
    Task<CustomerTypeOutput?> GetCustomerTypeWithCustomersAsync(int id);
}