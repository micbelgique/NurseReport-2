using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class ActivityType : Entity
    {
        [Required]
        public string Name { get; set; }

        public string DefaultComment { get; set; }
    }
}
