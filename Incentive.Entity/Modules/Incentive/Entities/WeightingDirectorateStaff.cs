using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damas.Domain.Shared;
using Incentive.Entity.Modules.Incentive.Enums;
using Incentive.Entity.Modules.Incentive.Indexs;
using Incentive.Entity.Modules.Incentive.RootEntities;

namespace Incentive.Entity.Modules.Incentive.Entities
{
    /// <summary>
    /// لعرض تثقيل موظفي المديرية وعددهم
    /// </summary>
    public class WeightingDirectorateStaff:EntityBase
    {
        /// <summary>
        /// التثقيل
        /// </summary>
        public double Weighting { get; set; }
        public JobCategory JobCategory { get; set; }
        public JobTitle JobTitle { get; set; }
        public Directorate Directorate { get; set; }
    }
}
