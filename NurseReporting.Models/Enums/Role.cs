using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models.Enums
{
    [Flags]
    public enum Role : int
    {
        Administrator = 255,
        Parent = 1,
        Nurse = 2
    }
}

