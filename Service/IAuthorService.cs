using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IAuthorService
{
    Task<List<AuthorOutput>> GetAllAsync();
    Task<AuthorOutput?> GetByIdAsync(int id);
    Task<AuthorOutput> AddAsync(AuthorInput authorInput);
    Task<AuthorOutput?> UpdateAsync(int id, AuthorInput authorInput);
    Task<AuthorOutput?> DeleteAsync(int id);
    Task<AuthorOutput?> GetAuthorWithBooksAsync(int id);
}