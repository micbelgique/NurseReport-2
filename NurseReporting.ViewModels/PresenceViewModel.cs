using NurseReporting.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NurseReporting.Models;

namespace NurseReporting.ViewModels
{
    public class PresenceViewModel : IPresenceViewModel
    {
        public Guid EntityId { get; set; }

        public IEnumerable<Presence> ScheduleDates { get; set; }

        public bool Load(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
