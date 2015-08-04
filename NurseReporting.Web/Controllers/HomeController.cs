using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NurseReporting.Web.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            List<string> roles = new List<string>();

            if (User.IsInRole("Administrator")) roles.Add("Administrator");
            if (User.IsInRole("Nurse")) roles.Add("Nurse");
            if (User.IsInRole("Parent")) roles.Add("Parent");
            
            ViewBag.UserRoles = String.Join(",", roles);
            return View();
        }

    }
}