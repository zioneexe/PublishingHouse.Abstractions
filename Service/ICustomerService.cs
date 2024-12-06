using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Service.General;

namespace PublishingHouse.Abstractions.Service
{
    public interface ICustomerService : ICrudService<ICustomer>, IGetIdByUserIdService<ICustomer>, IAccessCheckService<ICustomer> { }
}