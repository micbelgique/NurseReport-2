using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NurseReporting.Web.Startup))]
namespace NurseReporting.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
