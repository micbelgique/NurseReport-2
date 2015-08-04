using NurseReporting.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NurseReporting.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            using (DataContext dataContext = DataContextFactory.Instance.Create())
            {
                var parents = dataContext.Contacts.ToList();
            }
            GlobalConfiguration.Configure(WebApiConfig.Register);

            using (ApplicationDbContext dataContext = new ApplicationDbContext())
            {
                var users = dataContext.Users.ToList();
            }

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
