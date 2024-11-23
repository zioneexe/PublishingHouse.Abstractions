using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IEmployeeService
{
    Task<List<EmployeeOutput>> GetAllAsync();
    Task<EmployeeOutput?> GetByIdAsync(int id);
    Task<EmployeeOutput> AddAsync(EmployeeInput employeeInput);
    Task<EmployeeOutput?> UpdateAsync(int id, EmployeeInput employeeInput);
    Task<EmployeeOutput?> DeleteAsync(int id);
    Task<EmployeeOutput?> GetEmployeeWithDetailsAsync(int id);
}