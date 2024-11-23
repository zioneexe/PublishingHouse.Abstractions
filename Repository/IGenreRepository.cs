using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository;

public interface IGenreRepository
{
    Task<List<IGenre>> GetAllAsync();
    Task<IGenre?> GetByIdAsync(int id);
    Task<IGenre> AddAsync(IGenre genre);
    Task<IGenre?> UpdateAsync(int id, IGenre genre);
    Task<IGenre?> DeleteAsync(int id);
}