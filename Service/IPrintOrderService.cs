using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IPrintOrderService
{
    Task<List<PrintOrderOutput>> GetAllAsync();
    Task<PrintOrderOutput?> GetByIdAsync(int id);
    Task<PrintOrderOutput> AddAsync(PrintOrderInput printOrderInput);
    Task<PrintOrderOutput?> UpdateAsync(int id, PrintOrderInput printOrderInput);
    Task<PrintOrderOutput?> DeleteAsync(int id);
    Task<PrintOrderOutput?> GetPrintOrderWithDetailsAsync(int id);
}