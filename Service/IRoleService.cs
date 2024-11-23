using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublishingHouse.Abstractions.Model;
using PublishingHouse.Shared.Model.Input;
using PublishingHouse.Shared.Model.Output;

namespace PublishingHouse.Abstractions.Service
{
    public interface IRoleService
    {
        Task<List<RoleOutput>> GetAllAsync();
        Task<RoleOutput?> GetByIdAsync(int id);
        Task<RoleOutput> AddAsync(RoleInput roleInput);
        Task<RoleOutput?> UpdateAsync(int id, RoleInput role);
        Task<RoleOutput?> DeleteAsync(int id);
    }
}
