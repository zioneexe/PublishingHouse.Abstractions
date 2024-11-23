using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublishingHouse.Abstractions.Model;

namespace PublishingHouse.Abstractions.Repository
{
    public interface IRoleRepository
    {
        Task<IRole?> GetByIdAsync(int roleId);
        Task<List<IRole>> GetAllAsync();
        Task<IRole> AddAsync(IRole role);
        Task<IRole?> UpdateAsync(int id, IRole role);
        Task<IRole?> DeleteAsync(int roleId);
    }
}
