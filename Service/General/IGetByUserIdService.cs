using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Abstractions.Service.General
{
    public interface IGetIdByUserIdService<T>
    {
        Task<int> GetIdByUserIdAsync(string userId);
    }
}
