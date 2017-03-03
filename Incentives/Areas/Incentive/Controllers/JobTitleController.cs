using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Damas.Infrastructure.Repositories;
using Incentive.Entity.Modules.Incentive.Indexs;

namespace Incentives.Areas.Incentive.Controllers
{
    public class JobTitleController : Controller
    {
        RepositoryBase<JobTitle> _context=new RepositoryBase<JobTitle>();
        // GET: /Incentive/JobTitle/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Read()
        {
            var jobTitle = _context.GetAll().ToList();
            return Json(jobTitle, JsonRequestBehavior.AllowGet);
        }
	}
}