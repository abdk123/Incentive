using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damas.Domain.Shared;

namespace Damas.Domain.Modules.Security.Entities
{
    public class Role:EntityBase
    {
        public string RoleName { get; set; }
        public Collection<User> Users { get; set; } 
    }
}
