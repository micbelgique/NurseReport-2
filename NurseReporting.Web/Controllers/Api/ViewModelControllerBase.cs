using NurseReporting.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NurseReporting.Web.Controllers.Api
{
    public abstract class ViewModelControllerBase<T> : ApiController where T : IPersistentViewModel
    {
        // GET: api/Contact/5
        public IHttpActionResult Get(Guid id)
        {
            IPersistentViewModel viewModel = Activator.CreateInstance<T>();
            if (viewModel.Load(id))
            {
                return Ok(viewModel);
            }
            return NotFound();
        }

        // POST: api/Contact
        public IHttpActionResult Post([FromBody]T value)
        {
            value.Save();
            return Ok();
        }
    }
}
