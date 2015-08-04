using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Interfaces.ViewModels
{
    public interface IDailyObservableViewModel : IPersistentViewModel
    {
        string LunchComment { get; set; }
        int LunchRating { get; set; }
        string SnackComment { get; set; }
        int SnackRating { get; set; }
        DateTime? NapFrom { get; set; }
        DateTime? NapTo { get; set; }
        bool IsNapRestless { get; set; }
        bool IsNapNormal { get; set; }
        string NapComment { get; set; }
        string PoohComment { get; set; }
        string ObservationComment { get; set; }

    }
}
