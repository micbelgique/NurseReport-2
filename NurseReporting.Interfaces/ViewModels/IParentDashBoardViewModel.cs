using NurseReporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Interfaces.ViewModels
{
    public interface IParentDashBoardViewModel
    {
        IEnumerable<Child> Children { get; set; }
    }
}
