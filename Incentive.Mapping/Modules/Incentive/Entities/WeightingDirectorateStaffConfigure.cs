using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Incentive.Entity.Modules.Incentive.Entities;

namespace Incentive.Mapping.Modules.Incentive.Entities
{
    public class WeightingDirectorateStaffConfigure : EntityTypeConfiguration<WeightingDirectorateStaff>
    {
        public WeightingDirectorateStaffConfigure()
        {
            HasKey(x=>x.Id);

            Property(x => x.JobCategory);
            Property(x => x.Weighting);

            HasRequired(x => x.JobTitle);
            HasRequired(x => x.Directorate);
        }
    }
}
