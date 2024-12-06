using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Repository.General;

namespace PublishingHouse.Abstractions.Repository
{
    public interface ICustomerRepository : IRepository<ICustomer>, IGetIdByUserIdRepository<ICustomer> { }
}