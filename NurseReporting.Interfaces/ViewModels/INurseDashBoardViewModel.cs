using NurseReporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Interfaces.ViewModels
{
    public interface INurseDashBoardViewModel
    {
        IEnumerable<Child> Children { get; set; }
    }
}
