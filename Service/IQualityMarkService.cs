using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IQualityMarkService
{
    Task<List<QualityMarkOutput>> GetAllAsync();
    Task<QualityMarkOutput?> GetByIdAsync(int id);
    Task<QualityMarkOutput> AddAsync(QualityMarkInput qualityMarkInput);
    Task<QualityMarkOutput?> UpdateAsync(int id, QualityMarkInput qualityMarkInput);
    Task<QualityMarkOutput?> DeleteAsync(int id);
    Task<QualityMarkOutput?> GetQualityMarkWithBatchPrintsAsync(int id);
}