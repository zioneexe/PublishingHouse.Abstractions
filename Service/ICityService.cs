using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface ICityService
{
    Task<List<CityOutput>> GetAllAsync();
    Task<CityOutput?> GetByIdAsync(int id);
    Task<CityOutput> AddAsync(CityInput cityInput);
    Task<CityOutput?> UpdateAsync(int id, CityInput cityInput);
    Task<CityOutput?> DeleteAsync(int id);
    Task<CityOutput?> GetCityWithDetailsAsync(int id);
}