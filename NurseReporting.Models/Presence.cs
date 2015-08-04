using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class Presence : Entity
    {
        public Child Child { get; set; }

        public DateTime Date { get; set; }

        public bool MorningForecast { get; set; }

        public bool AfternoonForecast { get; set; }

        public bool? MorningEffective { get; set; }

        public bool? AfternoonEffective { get; set; }

        public AbsenceReason AbsenceReason { get; set; }

        public string Comment { get; set; }
    }
}
