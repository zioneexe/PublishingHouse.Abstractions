using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Repository.General;

namespace PublishingHouse.Abstractions.Repository
{
    public interface IOrderBookRepository : IRepository<IOrderBook>
    {
        public Task<IEnumerable<IOrderBook>> GetByOrderIdAsync(int orderId);

        public Task DeleteByOrderIdAsync(int orderId);
    }
}