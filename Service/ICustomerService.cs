using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface ICustomerService
{
    Task<List<CustomerOutput>> GetAllAsync();
    Task<CustomerOutput?> GetByIdAsync(int id);
    Task<CustomerOutput> AddAsync(CustomerInput customerInput);
    Task<CustomerOutput?> UpdateAsync(int id,CustomerInput customerInput);
    Task<CustomerOutput?> DeleteAsync(int id);
    Task<CustomerOutput?> GetCustomerWithOrdersAsync(int id);
}