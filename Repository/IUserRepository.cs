using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IUserRepository
{
    Task<List<IUser>> GetAllAsync();
    Task<IUser?> GetByIdAsync(int id);
    Task<IUser?> GetByUsernameAsync(string username);
    Task<IUser> AddAsync(IUser user);
    Task<IUser?> UpdateAsync(int id, IUser user);
    Task<IUser?> DeleteAsync(int id);
}