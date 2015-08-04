using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class Child : Person
    {
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime EstimatedEndDate { get; set; }

        public virtual IEnumerable<Contact> Contacts { get; set; }

        public Section Section { get; set; }

        public virtual IEnumerable<Allergy> Allergies { get; set; }

        public DateTime BirthDate { get; set; }

        public string Comment { get; set; }

    }
}
