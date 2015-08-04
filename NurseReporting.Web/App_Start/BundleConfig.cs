using System.Web.Optimization;

namespace NurseReporting.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/app").IncludeDirectory("~/WebApp", "*.js", true));
            bundles.Add(new ScriptBundle("~/bundles/angular")
                   .Include("~/Scripts/angular.min.js")
                   .Include("~/Scripts/angular-ui-router.min.js")
                   .Include("~/Scripts/ui-bootstrap-tpls-0.13.1.min.js"));          
        }
    }
}
