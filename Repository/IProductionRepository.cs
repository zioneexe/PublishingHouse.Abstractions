using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IProductionRepository
{
    Task<List<IProduction>> GetAllAsync();
    Task<IProduction?> GetByIdAsync(int id);
    Task<List<IProduction>> GetByCityIdAsync(int cityId);
    Task<List<IProduction>> GetByProductionTypeIdAsync(int productionTypeId);
    Task<IProduction> AddAsync(IProduction production);
    Task<IProduction?> UpdateAsync(int id, IProduction production);
    Task<IProduction?> DeleteAsync(int id);
}