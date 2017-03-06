using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Incentive.Entity.Modules.Incentive.Entities;

namespace Incentive.Mapping.Modules.Incentive.Entities
{
    public class EvaluationAnswerConfigure:EntityTypeConfiguration<EvaluationAnswer>
    {
        public EvaluationAnswerConfigure()
        {
            HasKey(x => x.Id);

            Property(x => x.Degree);

            HasRequired(x => x.DegreeQuestion);
            HasRequired(x => x.Evaluation);
        }
    }
}
