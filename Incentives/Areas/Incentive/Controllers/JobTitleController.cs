using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Damas.Domain.Interfaces.Repositories;
using Damas.Infrastructure.Repositories;
using Incentive.Entity.Modules.Incentive.Indexs;
using Incentives.Repositories;
using Incentives.Repositories.Factory;

namespace Incentives.Areas.Incentive.Controllers
{
    public class JobTitleController : Controller
    {
        IRepositoryBase<JobTitle> _context=new RepositoryBase<JobTitle>();
        // GET: /Incentive/JobTitle/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Read()
        {
            var repository=DamasFactory.GetRepositoryInstance<JobTitle, JobTitleReporitory>();
            
            return Json(repository.GetIndexAfterOrder()
                , JsonRequestBehavior.AllowGet);
        }
	}
}