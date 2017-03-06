using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Damas.Domain.Interfaces.Repositories;
using Damas.Infrastructure.Context;
using Damas.Infrastructure.Repositories;
using Incentive.Entity.Modules.Incentive.Indexs;

namespace Incentives.Repositories
{
    public class JobTitleReporitory:RepositoryBase<JobTitle>
    {
        readonly DamasContext context=new DamasContext();

       public IEnumerable<JobTitle> GetIndexAfterOrder()
       {
           return context.Set<JobTitle>().OrderBy(x=>x.Order).ToList();
       }
    }
}