using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IBookService
{
    Task<List<BookOutput>> GetAllAsync();
    Task<BookOutput?> GetByIdAsync(int id);
    Task<BookOutput> AddAsync(BookInput bookInput);
    Task<BookOutput?> UpdateAsync(int id, BookInput bookInput);
    Task<BookOutput?> DeleteAsync(int id);
    Task<BookOutput?> GetBookWithDetailsAsync(int id);
}