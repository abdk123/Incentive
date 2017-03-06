using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Incentive.Entity.Modules.Incentive.Entities;

namespace Incentive.Mapping.Modules.Incentive.Entities
{
    public class WorkerConfigure:EntityTypeConfiguration<Worker>
    {
        public WorkerConfigure()
        {
            HasKey(x => x.Id);
            Property(x => x.FullName);
            Property(x => x.JobCategory);
            Property(x => x.StartDate);

            HasRequired(x => x.JobTitle);
            HasRequired(x => x.Directorate);
        }
    }
}
