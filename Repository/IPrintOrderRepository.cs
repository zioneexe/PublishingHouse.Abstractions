using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Repository.General;

namespace PublishingHouse.Abstractions.Repository
{
    public interface IPrintOrderRepository : IRepository<IPrintOrder>
    {
        public Task<IEnumerable<IPrintOrder>> GetByCustomerIdAsync(int customerId);
        public Task<IEnumerable<IPrintOrder>> GetByEmployeeIdAsync(int employeeId);
        public Task UpdateOrderStatusAsync(int orderId, IOrderStatus orderStatus);
        public Task<int> AddWithIdAsync(IPrintOrder entity);
    }
}