using NurseReporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Interfaces.ViewModels
{
    public interface IChildCardViewModel : IPersistentViewModel
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        DateTime BirthDate { get; set; }

        IEnumerable<Contact> Contacts { get; set; }
        IEnumerable<Allergy> Allergies { get; set; }
        string Note { get; set; }
        DateTime StartDate { get; set; }
        DateTime? EndDate { get; set; }
        DateTime EstimatedEndDate { get; set; }

    }
}
