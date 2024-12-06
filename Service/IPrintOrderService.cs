using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Service.General;

namespace PublishingHouse.Abstractions.Service
{
    public interface IPrintOrderService : ICrudService<IPrintOrder>
    {
        Task<IEnumerable<IPrintOrder>> GetByCustomerIdAsync(int customerId);

        Task<IEnumerable<IPrintOrder>> GetByEmployeeIdAsync(int employeeId);

        Task CancelOrderAsync(int orderId);

        Task<int> AddWithIdAsync(IPrintOrder entity);
    }
}