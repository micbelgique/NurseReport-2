using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class Activity : Entity
    {
        [Required]
        public DateTime Time { get; set; }

        public Section Section { get; set; }

        [Required]
        public ActivityType Type { get; set; }

        public string Comment { get; set; }
    }
}
