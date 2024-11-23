using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IProductionTypeService
{
    Task<List<ProductionTypeOutput>> GetAllAsync();
    Task<ProductionTypeOutput?> GetByIdAsync(int id);
    Task<ProductionTypeOutput> AddAsync(ProductionTypeInput productionTypeInput);
    Task<ProductionTypeOutput?> UpdateAsync(int id, ProductionTypeInput productionTypeInput);
    Task<ProductionTypeOutput?> DeleteAsync(int id);
    Task<ProductionTypeOutput?> GetProductionTypeWithProductionsAsync(int id);
}