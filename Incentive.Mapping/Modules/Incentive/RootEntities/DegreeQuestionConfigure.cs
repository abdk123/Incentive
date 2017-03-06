using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Incentive.Entity.Modules.Incentive.RootEntities;

namespace Incentive.Mapping.Modules.Incentive.RootEntities
{
    public class DegreeQuestionConfigure:EntityTypeConfiguration<DegreeQuestion>
    {
        public DegreeQuestionConfigure()
        {
            HasKey(x => x.Id);
            Property(x => x.Degree);

            HasMany(x => x.Answers);
            HasMany(x => x.Questions);
        }
    }
}
