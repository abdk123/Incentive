﻿using System.Collections.ObjectModel;
using System.Linq;
using Damas.Domain.Shared;
using Incentive.Entity.Modules.Incentive.Entities;

namespace Incentive.Entity.Modules.Incentive.RootEntities
{
    public class Directorate:EntityBase
    {
        public string DirectorateName { get; set; }

        /// <summary>
        /// ارتباطها بالخدمات المقدمة للمواطن
        /// </summary>
        public int ServicesProvidedToCitizen { get; set; }

        public int ServicesProvidedToCitizenPercent { get; set; }

        /// <summary>
        /// عدد المعاملات
        /// </summary>
        public int TransactionNumber { get; set; }
        public int TransactionNumberPercent { get; set; }

        /// <summary>
        /// تكرار المعاملات(عدد المواطنين اليومي)
        /// </summary>
        public int TransactionRepetition { get; set; }
        public int TransactionRepetitionPercent { get; set; }

        /// <summary>
        /// حساسية العمل
        /// </summary>
        public int WorkSensitivity { get; set; }
        public int WorkSensitivityPrecent { get; set; }

        /// <summary>
        /// حجم وضغط العمل
        /// </summary>
        public int WorkPressure { get; set; }
        public int WorkPressurePresent { get; set; }

        /// <summary>
        /// عدد الموظفين
        /// </summary>
        public int EmployeesCount { get { return Employees.Count(x => x.Directorate.Id == this.Id); } }
        public int EmployeesCountPercent { get; set; }

        public bool PresentIsAhundred
        {
            get
            {
                var value = ServicesProvidedToCitizenPercent + TransactionNumberPercent + TransactionRepetitionPercent +
                            WorkSensitivityPrecent + WorkPressurePresent + EmployeesCountPercent;


                return value == 100 ? true : false;
            }
        }

        public Collection<Employee> Employees { get; set; }
        public Collection<Worker> Workers { get; set; }
        public Collection<WeightingDirectorateStaff> WeightingDirectorateStaffs { get; set; }
    }
}
