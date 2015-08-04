using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class DayFile : Entity
    {
        public Child Child { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<DayEvent> Events { get; set; }
    }
}
