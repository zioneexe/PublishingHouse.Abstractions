using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IProductionTypeRepository 
{
    Task<List<IProductionType>> GetAllAsync();
    Task<IProductionType?> GetByIdAsync(int id);
    Task<IProductionType> AddAsync(IProductionType productionType);
    Task<IProductionType?> UpdateAsync(int id, IProductionType productionType);
    Task<IProductionType?> DeleteAsync(int id);
}