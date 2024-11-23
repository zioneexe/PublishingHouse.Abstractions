using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IUserService
{
    Task<List<UserOutput>> GetAllAsync();
    Task<UserOutput?> GetByIdAsync(int id);
    Task<UserOutput> AddAsync(UserInput userInput);
    Task<UserOutput?> UpdateAsync(int id, UserInput userInput);
    Task<UserOutput?> DeleteAsync(int id);
    Task<UserOutput?> GetUserByUsernameAsync(string username);
    Task<UserOutput?> GetUserByEmailAsync(string email);
}