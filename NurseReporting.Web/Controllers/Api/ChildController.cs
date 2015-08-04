using NurseReporting.DataAccess;
using NurseReporting.Models;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Linq;
using System;

namespace NurseReporting.Web.Controllers.Api
{
    [RoutePrefix("api/child")]
    public class ChildController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        [Route("getChildren")]
        public IHttpActionResult GetChildren()
        {
            using (DataContext datacontext = DataContextFactory.Instance.Create())
            {
                if (User.IsInRole("Administrator"))
                {
                    var children = datacontext.Children.ToList();
                    return Ok(children);
                }

                if (User.IsInRole("Nurse"))
                {
                    DateTime date = new DateTime(2014, 9, 17);
                    var children = datacontext.Children.Where(child => child.BirthDate < date).ToList();
                    return Ok(children);
                }

                if (User.IsInRole("Parent"))
                {
                    DateTime date = new DateTime(2014, 5, 1);
                    var children = datacontext.Children.Where(child => child.BirthDate < date).ToList(); 
                    return Ok(children);
                }

                return Unauthorized();

            }
        }

        // GET api/<controller>
        [HttpGet]
        [Route("getContacts/{childID}")]
        public IHttpActionResult GetContacts(Guid childID)
        {
            using (DataContext datacontext = DataContextFactory.Instance.Create())
            {
                var contacts = datacontext.Children.FirstOrDefault(child => child.Id == childID)?.Contacts.ToList();
                return Ok(contacts);
            }
        }


        [HttpPost]
        [Route("update/")]
        public IHttpActionResult InsertOrUpdateChild(Child child)
        {
            using (DataContext datacontext = DataContextFactory.Instance.Create())
            {
                if (child.Id == null)
                {
                    child.Id = Guid.NewGuid();
                    datacontext.Children.Add(child);
                }
                else
                {
                    Child currentChild = datacontext.Children.Where(c => c.Id == child.Id).FirstOrDefault();

                    if (currentChild != null)
                    {
                        currentChild = child;
                    }
                    else
                    {
                        datacontext.Children.Add(child);
                    }
                }
            }

            return Ok(child);
        }
        
    }
}