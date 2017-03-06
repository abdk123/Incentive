using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Incentive.Entity.Modules.Incentive.Indexs;

namespace Incentive.Mapping.Modules.Incentive.Indexes
{
    public class JobTitleConfigure:EntityTypeConfiguration<JobTitle>
    {
        public JobTitleConfigure()
        {
            HasKey(x => x.Id);
            Property(x => x.Name);
            Property(x => x.Order).IsOptional();
        }
    }
}
