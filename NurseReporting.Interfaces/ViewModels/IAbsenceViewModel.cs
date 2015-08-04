using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Interfaces.ViewModels
{
    public interface IAbsenceViewModel : IPersistentViewModel
    {
        Guid UserID { get; set; }
        IEnumerable<Guid> ChildIDs { get; set; }
        DateTime Date { get; set; }
        string Comment { get; set; }
        IEnumerable<Models.AbsenceReason> Reasons { get; set; }
    }
}
