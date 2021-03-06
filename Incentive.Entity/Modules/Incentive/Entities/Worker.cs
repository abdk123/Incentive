﻿using System;
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
    public class Worker:EntityBase
    {

        public string FullName { get; set; }
        /// <summary>
        /// فئة الموظف
        /// </summary>
        public JobCategory JobCategory { get; set; }

        /// <summary>
        /// الصفة الوظيفية
        /// </summary>
        public JobTitle JobTitle { get; set; }

        /// <summary>
        /// تاريخ بدء التعيين
        /// </summary>
        public DateTime? StartDate { get; set; }
        public Directorate Directorate { get; set; }
    }
}
