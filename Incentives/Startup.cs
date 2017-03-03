using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Incentives.Startup))]
namespace Incentives
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
