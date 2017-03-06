using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Incentive.Entity.Modules.Incentive.Indexs;

namespace Incentive.Mapping.Modules.Incentive.Indexes
{
    public class QuestionsGroupConfigure:EntityTypeConfiguration<QuestionsGroup>
    {
        public QuestionsGroupConfigure()
        {
            HasKey(x => x.Id);
            Property(x => x.Name);
            Property(x => x.Order).IsOptional();
        }
    }
}
