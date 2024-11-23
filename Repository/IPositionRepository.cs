using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IPositionRepository
{
    Task<List<IPosition>> GetAllAsync();
    Task<IPosition?> GetByIdAsync(int id);
    Task<IPosition?> GetByNameAsync(string name);
    Task<IPosition> AddAsync(IPosition position);
    Task<IPosition?> UpdateAsync(int id, IPosition position);
    Task<IPosition?> DeleteAsync(int id);
}