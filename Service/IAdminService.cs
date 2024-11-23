using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IAdminService
{
    Task<List<AdminOutput>> GetAllAsync();
    Task<AdminOutput?> GetByIdAsync(int id); 
    Task<AdminOutput> AddAsync(AdminInput adminInput);
    Task<AdminOutput?> UpdateAsync(int id, AdminInput adminInput); 
    Task<AdminOutput?> DeleteAsync(int id); 
    Task<AdminOutput?> GetAdminWithUserAsync(int id); 
}