using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IBookRepository
{
    Task<List<IBook>> GetAllAsync();
    Task<IBook?> GetByIdAsync(int id);
    Task<List<IBook>> GetByGenreIdAsync(int genreId);
    Task<List<IBook>> GetByAuthorIdAsync(int authorId);
    Task<IBook> AddAsync(IBook book);
    Task<IBook?> UpdateAsync(int id, IBook book);
    Task<IBook?> DeleteAsync(int id);
}