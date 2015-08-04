using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class Section : Entity
    {
        public string Name { get; set; }

        public Nurse SectionManager { get; set; }

        public IEnumerable<Nurse> AlternateNurses { get; set; }
    }
}
