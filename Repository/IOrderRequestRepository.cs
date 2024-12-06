using Microsoft.AspNetCore.Http;
using PublishingHouse.Abstractions.Entity;
using PublishingHouse.Abstractions.Repository.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Abstractions.Repository
{
    public interface IOrderRequestRepository : IRepository<IOrderRequest>
    {
        Task<string> SaveFileAsync(IFormFile file);

        Task<IEnumerable<IOrderRequest>> GetByCustomerIdAsync(int customerId);
    }
}
