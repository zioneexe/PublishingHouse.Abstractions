using PublishingHouse.Abstractions.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PublishingHouse.Abstractions.Service.General;

namespace PublishingHouse.Abstractions.Service
{
    public interface IOrderRequestService : ICrudService<IOrderRequest>
    {
        Task<string> SaveFileAsync(IFormFile file);

        Task<IEnumerable<IOrderRequest>> GetByCustomerIdAsync(int customerId);

        double CalculatePrice(IOrderRequest entity);
    }
}
