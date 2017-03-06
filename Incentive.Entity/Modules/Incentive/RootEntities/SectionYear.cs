using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damas.Domain.Shared;

namespace Incentive.Entity.Modules.Incentive.RootEntities
{
    public class SectionYear:EntityBase
    {
        
        public int Year { get; set; }
        public int Part { get; set; }
    }
}
