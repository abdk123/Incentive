using System.Collections.Generic;
using System.Linq;
using Damas.Domain.Shared;
using Incentive.Entity.Modules.Incentive.Entities;

namespace Incentive.Entity.Modules.Incentive.RootEntities
{
    public class Evaluation:EntityBase
    {
        public Evaluation()
        {
            EvaluationAnswers=new List<EvaluationAnswer>();
        }
        public SectionYear SectionYear { get; set; }
        public Employee Employee { get; set; }
        public int FinalDegree { get { return EvaluationAnswers.Sum(x => x.Degree); }}
        public ICollection<EvaluationAnswer> EvaluationAnswers { get; set; }

        public double Money { get; set; }
    }
}
