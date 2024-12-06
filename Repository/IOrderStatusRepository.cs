using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Repository.General;

namespace PublishingHouse.Abstractions.Repository
{
    public interface IOrderStatusRepository : IRepository<IOrderStatus>
    {
        public Task<IOrderStatus?> GetByNameAsync(string name);
    }
}