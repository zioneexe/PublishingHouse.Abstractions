using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IOrderStatusService
{
    Task<List<OrderStatusOutput>> GetAllAsync();
    Task<OrderStatusOutput?> GetByIdAsync(int id);
    Task<OrderStatusOutput> AddAsync(OrderStatusInput orderStatusInput);
    Task<OrderStatusOutput?> UpdateAsync(int id, OrderStatusInput orderStatusInput);
    Task<OrderStatusOutput?> DeleteAsync(int id);
    Task<OrderStatusOutput?> GetOrderStatusWithPrintOrdersAsync(int id);
}