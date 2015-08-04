using NurseReporting.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NurseReporting.Models;

namespace NurseReporting.ViewModels
{
    public class DashBoardViewModel : IDashBoardViewModel
    {
        public IEnumerable<Child> Children { get; set; }

        public Guid EntityId { get; set; }

        public bool Load(Guid entityId)
        {
            //if (User.IsInRole("Administrator"))
            //{
            //}


            //if (User.IsInRole("Nurse"))
            //{
            //}


            //if (User.IsInRole("Parent"))
            //{
            //}
            throw new NotImplementedException();


        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
