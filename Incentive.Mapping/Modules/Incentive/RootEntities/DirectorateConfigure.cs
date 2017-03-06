using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Incentive.Entity.Modules.Incentive.RootEntities;

namespace Incentive.Mapping.Modules.Incentive.RootEntities
{
    public class DirectorateConfigure:EntityTypeConfiguration<Directorate>
    {
        public DirectorateConfigure()
        {
            HasKey(x => x.Id);

            Property(x => x.DirectorateName);
            Property(x => x.EmployeesCount);
            Property(x => x.EmployeesCountPercent);
            Property(x => x.ServicesProvidedToCitizen);
            Property(x => x.ServicesProvidedToCitizenPercent);
            Property(x => x.TransactionNumber);
            Property(x => x.TransactionNumberPercent);
            Property(x => x.TransactionRepetition);
            Property(x => x.TransactionRepetitionPercent);
            Property(x => x.WorkPressure);
            Property(x => x.WorkPressurePresent);
            Property(x => x.WorkSensitivity);
            Property(x => x.WorkSensitivityPrecent);

            HasMany(x => x.Employees);
            HasMany(x => x.WeightingDirectorateStaffs);
            HasMany(x => x.Workers);

        }
    }
}
