using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IAuthorRepository
{
    Task<List<IAuthor>> GetAllAsync();
    Task<IAuthor?> GetByIdAsync(int id);
    Task<IAuthor> AddAsync(IAuthor author);
    Task<IAuthor?> UpdateAsync(int id, IAuthor author);
    Task<IAuthor?> DeleteAsync(int id);
    Task<IAuthor?> GetAuthorWithBooksAsync(int id);
}