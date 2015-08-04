using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Interfaces.ViewModels
{
    public interface IAdmissionViewModel : IPersistentViewModel
    {
        string Reference { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        DateTime BirthDate { get; set; }
        DateTime From { get; set; }
        DateTime RequestDate { get; set; }
        DateTime? AcceptedDate { get; set; }
        DateTime ReceptionDate { get; set; }
        int? DayPerWeek { get; set; }
        bool? IsNewInCity { get; set; }
        bool? IsOutsiteCity { get; set; }

    }
}
