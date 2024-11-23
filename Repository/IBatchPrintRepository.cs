using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IBatchPrintRepository
{
    Task<List<IBatchPrint>> GetAllAsync();
    Task<IBatchPrint?> GetByIdAsync(int id);
    Task<List<IBatchPrint>> GetByPrintOrderIdAsync(int printOrderId);
    Task<List<IBatchPrint>> GetByQualityMarkIdAsync(int qualityMarkId);
    Task<IBatchPrint> AddAsync(IBatchPrint batchPrint);
    Task<IBatchPrint?> UpdateAsync(int id, IBatchPrint batchPrint);
    Task<IBatchPrint?> DeleteAsync(int id);
}