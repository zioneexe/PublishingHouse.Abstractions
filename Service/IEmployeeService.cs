using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Service.General;

namespace PublishingHouse.Abstractions.Service
{
    public interface IEmployeeService : ICrudService<IEmployee>, IGetIdByUserIdService<IEmployee> { }
}