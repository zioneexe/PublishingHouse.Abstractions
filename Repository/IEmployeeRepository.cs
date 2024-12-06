using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Repository.General;

namespace PublishingHouse.Abstractions.Repository
{
    public interface IEmployeeRepository : IRepository<IEmployee>, IGetIdByUserIdRepository<IEmployee> { }
}