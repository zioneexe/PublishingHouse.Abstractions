using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Service.General;

namespace PublishingHouse.Abstractions.Service
{
    public interface IBookService : ICrudService<IBook>
    {
        Task<int> AddWithIdAsync(IBook entity);
    }
}