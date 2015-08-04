using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class DayEvent : Entity
    {
        public EventType Type { get; set; }

        public string Data { get; set; }
        public DayFile DayFile { get; set; }
    }
}
