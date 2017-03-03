using System.Collections.ObjectModel;
using System.Linq;
using Damas.Domain.Shared;
using Incentive.Entity.Modules.Incentive.Entities;
using Incentive.Entity.Modules.Incentive.Indexs;

namespace Incentive.Entity.Modules.Incentive.RootEntities
{
    public class Evaluation:EntityBase
    {
        public SectionYear SectionYear { get; set; }
        public Employee Employee { get; set; }
        public int FinalDegree { get { return EvaluationAnswers.Sum(x => x.Degree); }}
        public Collection<EvaluationAnswer> EvaluationAnswers { get; set; }

        public double Money { get; set; }
    }
}
