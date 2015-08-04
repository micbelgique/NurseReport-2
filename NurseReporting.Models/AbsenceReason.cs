using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class AbsenceReason : Entity
    {
        [Required]
        public string Label { get; set; }

        [Required]
        public bool IsBillable { get; set; }
    }
}
