using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface ICityRepository
{
    Task<List<ICity>> GetAllAsync();
    Task<ICity?> GetByIdAsync(int id);
    Task<List<ICity>> GetByRegionIdAsync(int regionId);
    Task<ICity> AddAsync(ICity city);
    Task<ICity?> UpdateAsync(int id, ICity city);
    Task<ICity?> DeleteAsync(int id);
}