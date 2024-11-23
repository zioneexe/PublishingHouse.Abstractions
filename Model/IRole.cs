using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Abstractions.Model
{
    public interface IRole
    {
        int RoleId { get; set; }
        string Name { get; set; }
    }
}
