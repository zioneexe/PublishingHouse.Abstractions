using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IOrderBookRepository
{
    Task<List<IOrderBook>> GetAllAsync();
    Task<IOrderBook?> GetByIdAsync(int id);
    Task<IOrderBook> AddAsync(IOrderBook orderBook);
    Task<IOrderBook?> UpdateAsync(int id, IOrderBook orderBook);
    Task<IOrderBook?> DeleteAsync(int id);
    Task<List<IOrderBook>> GetOrderBooksByOrderIdAsync(int orderId);
    Task<List<IOrderBook>> GetOrderBooksByBookIdAsync(int bookId);
}