using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Repository.General;

namespace PublishingHouse.Abstractions.Repository
{
    public interface IBookRepository : IRepository<IBook>
    {
        public Task<int> AddWithIdAsync(IBook entity);

    }
}