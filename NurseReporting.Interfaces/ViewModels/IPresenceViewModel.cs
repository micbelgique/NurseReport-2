using NurseReporting.Interfaces.ViewModels;
using NurseReporting.Models;
using System.Collections.Generic;

namespace NurseReporting.ViewModels
{
    public interface IPresenceViewModel : IPersistentViewModel
    {
        IEnumerable<Presence> ScheduleDates { get; set; }
    }
}