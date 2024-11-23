using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IProductionService
{
    Task<List<ProductionOutput>> GetAllAsync();
    Task<ProductionOutput?> GetByIdAsync(int id);
    Task<ProductionOutput> AddAsync(ProductionInput productionInput);
    Task<ProductionOutput?> UpdateAsync(int id, ProductionInput productionInput);
    Task<ProductionOutput?> DeleteAsync(int id);
    Task<ProductionOutput?> GetProductionWithDetailsAsync(int id);
}