using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IEmployeeRepository
{
    Task<List<IEmployee>> GetAllAsync();
    Task<IEmployee?> GetByIdAsync(int id);
    Task<IEmployee> AddAsync(IEmployee employee);
    Task<IEmployee?> UpdateAsync(int id, IEmployee employee);
    Task<IEmployee?> DeleteAsync(int id);
    Task<List<IEmployee>> GetByPositionIdAsync(int positionId);
    Task<List<IEmployee>> GetByProductionIdAsync(int productionId);
}