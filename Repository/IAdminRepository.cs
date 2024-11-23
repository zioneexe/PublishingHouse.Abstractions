using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IAdminRepository
{
    Task<List<IAdmin>> GetAllAsync();
    Task<IAdmin?> GetByIdAsync(int id);
    Task<IAdmin> AddAsync(IAdmin admin);
    Task<IAdmin?> UpdateAsync(int id, IAdmin admin);
    Task<IAdmin?> DeleteAsync(int id);
}