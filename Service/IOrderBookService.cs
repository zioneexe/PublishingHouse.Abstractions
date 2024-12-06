using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Service.General;

namespace PublishingHouse.Abstractions.Service
{
    public interface IOrderBookService : ICrudService<IOrderBook>
    {
        public Task<IEnumerable<IOrderBook>> GetBooksByOrderIdAsync(int orderId);
    }
}