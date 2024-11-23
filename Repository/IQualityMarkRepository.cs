using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IQualityMarkRepository
{
    Task<List<IQualityMark>> GetAllAsync();
    Task<IQualityMark?> GetByIdAsync(int id);
    Task<IQualityMark> AddAsync(IQualityMark qualityMark);
    Task<IQualityMark?> UpdateAsync(int id, IQualityMark qualityMark);
    Task<IQualityMark?> DeleteAsync(int id);
}