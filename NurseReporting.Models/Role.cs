using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class Role : Entity
    {
        public string Name { get; set; }

        public Role ParentRole { get; set; }
    }
}
