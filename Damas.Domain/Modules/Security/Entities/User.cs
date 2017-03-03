using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damas.Domain.Shared;

namespace Damas.Domain.Modules.Security.Entities
{
    public class User:EntityBase
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Collection<Role> Roles { get; set; } 
    }
}
