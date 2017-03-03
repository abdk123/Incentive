using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas.Domain.Shared
{
    public class Index : EntityBase
    {
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
