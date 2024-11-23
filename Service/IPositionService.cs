using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IPositionService
{
    Task<List<PositionOutput>> GetAllAsync();
    Task<PositionOutput?> GetByIdAsync(int id);
    Task<PositionOutput> AddAsync(PositionInput positionInput);
    Task<PositionOutput?> UpdateAsync(int id, PositionInput positionInput);
    Task<PositionOutput?> DeleteAsync(int id);
    Task<PositionOutput?> GetPositionWithEmployeesAsync(int id);
}