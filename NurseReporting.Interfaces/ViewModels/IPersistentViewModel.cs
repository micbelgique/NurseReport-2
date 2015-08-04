using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Interfaces.ViewModels
{
    public interface IPersistentViewModel
    {
        Guid EntityId { get; set; }

        bool Load(Guid entityId);
        bool Save();
    }
}
