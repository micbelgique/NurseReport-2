using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public abstract class Person : Entity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
