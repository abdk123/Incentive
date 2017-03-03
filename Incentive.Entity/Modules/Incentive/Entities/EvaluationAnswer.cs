using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damas.Domain.Shared;
using Incentive.Entity.Modules.Incentive.RootEntities;

namespace Incentive.Entity.Modules.Incentive.Entities
{
    public class EvaluationAnswer:EntityBase
    {
        public int Degree { get; set; }
        public DegreeQuestion DegreeQuestion { get; set; }
        public Evaluation Evaluation { get; set; }
    }
}
