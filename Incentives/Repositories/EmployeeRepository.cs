using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Damas.Domain.Interfaces.Repositories;
using Damas.Infrastructure.Repositories;
using Incentive.Entity.Modules.Incentive.Entities;

namespace Incentives.Repositories
{
    public class EmployeeRepository:RepositoryBase<Employee>,IRepositoryBase<Employee>
    {
    }
}