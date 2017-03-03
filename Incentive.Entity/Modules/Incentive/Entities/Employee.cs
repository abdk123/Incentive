using System;
using Damas.Domain.Shared;
using Incentive.Entity.Modules.Incentive.Enums;
using Incentive.Entity.Modules.Incentive.Indexs;
using Incentive.Entity.Modules.Incentive.RootEntities;

namespace Incentive.Entity.Modules.Incentive.Entities
{
    public class Employee:EntityBase
    {
        /// <summary>
        /// الاسم الكامل
        /// </summary>
        public string FullName { get; set; }

        public Directorate Directorate { get; set; }

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
        /// <summary>
        /// مهندل ام لا
        /// </summary>
        public bool IsEngineer { get; set; }

        public Evaluation Evaluation { get; set; }
    }
}
