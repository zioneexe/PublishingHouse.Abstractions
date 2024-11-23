using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IPrintOrderRepository
{
    Task<List<IPrintOrder>> GetAllAsync();
    Task<IPrintOrder?> GetByIdAsync(int id);
    Task<List<IPrintOrder>> GetByCustomerIdAsync(int customerId);
    Task<List<IPrintOrder>> GetByEmployeeIdAsync(int employeeId);
    Task<List<IPrintOrder>> GetByOrderStatusIdAsync(int orderStatusId);
    Task<IPrintOrder> AddAsync(IPrintOrder printOrder);
    Task<IPrintOrder?> UpdateAsync(int id, IPrintOrder printOrder);
    Task<IPrintOrder?> DeleteAsync(int id);
}