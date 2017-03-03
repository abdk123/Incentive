using System.Web.Mvc;

namespace Incentives.Areas.Incentive
{
    public class IncentiveAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Incentive";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Incentive_default",
                "Incentive/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}