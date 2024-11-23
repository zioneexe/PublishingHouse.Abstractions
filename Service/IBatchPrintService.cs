using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IBatchPrintService
{
    Task<List<BatchPrintOutput>> GetAllAsync();
    Task<BatchPrintOutput?> GetByIdAsync(int id);
    Task<BatchPrintOutput> AddAsync(BatchPrintInput batchPrintInput);
    Task<BatchPrintOutput?> UpdateAsync(int id, BatchPrintInput batchPrintInput);
    Task<BatchPrintOutput?> DeleteAsync(int id);
    Task<BatchPrintOutput?> GetBatchPrintWithDetailsAsync(int id);
}