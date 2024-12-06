using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Abstractions.Service.General
{
    public interface IAccessCheckService<TRequest>
    {
        public Task<bool> HasUserAccess(int accessedId, string userId);
    }
}
