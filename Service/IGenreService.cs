using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service;

public interface IGenreService
{
    Task<List<GenreOutput>> GetAllAsync();
    Task<GenreOutput?> GetByIdAsync(int id);
    Task<GenreOutput> AddAsync(GenreInput genreInput);
    Task<GenreOutput?> UpdateAsync(int id, GenreInput genreInput);
    Task<GenreOutput?> DeleteAsync(int id);
    Task<GenreOutput?> GetGenreWithBooksAsync(int id);
}