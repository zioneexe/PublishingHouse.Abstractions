using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IOrderBookService
{
    Task<List<OrderBookOutput>> GetAllAsync();
    Task<OrderBookOutput?> GetByIdAsync(int id);
    Task<OrderBookOutput> AddAsync(OrderBookInput orderBookInput);
    Task<OrderBookOutput?> UpdateAsync(int id, OrderBookInput orderBookInput);
    Task<OrderBookOutput?> DeleteAsync(int id);
    Task<OrderBookOutput?> GetOrderBookWithDetailsAsync(int id);
}