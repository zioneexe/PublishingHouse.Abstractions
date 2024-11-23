using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IRegionRepository
{
    Task<List<IRegion>> GetAllAsync();
    Task<IRegion?> GetByIdAsync(int id);
    Task<IRegion> AddAsync(IRegion region);
    Task<IRegion?> UpdateAsync(int id, IRegion region);
    Task<IRegion?> DeleteAsync(int id);
}