using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IOrderStatusRepository
{
    Task<List<IOrderStatus>> GetAllAsync();
    Task<IOrderStatus?> GetByIdAsync(int id);
    Task<IOrderStatus?> GetByNameAsync(string name);
    Task<IOrderStatus> AddAsync(IOrderStatus orderStatus);
    Task<IOrderStatus?> UpdateAsync(int id, IOrderStatus orderStatus);
    Task<IOrderStatus?> DeleteAsync(int id);
}