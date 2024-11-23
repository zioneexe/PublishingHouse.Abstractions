using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IRegionService
{
    Task<List<RegionOutput>> GetAllAsync();
    Task<RegionOutput?> GetByIdAsync(int id);
    Task<RegionOutput> AddAsync(RegionInput regionInput);
    Task<RegionOutput?> UpdateAsync(int id, RegionInput regionInput);
    Task<RegionOutput?> DeleteAsync(int id);
    Task<RegionOutput?> GetRegionWithCitiesAsync(int id);
}