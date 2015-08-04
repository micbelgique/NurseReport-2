using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class AdmissionRequest : Entity
    {
        [Required]
        public string RequestNumber { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime ForeseenStartDate { get; set; }

        public DateTime RequestDate { get; set; }

        public DateTime ReceptionDate { get; set; }

        public DateTime? DateReported { get; set; }

        public DateTime? AcceptedDate { get; set; }

        public bool? LivesInMunicipality { get; set; }

        public int? WeeklyRate { get; set; }

        public bool? IsNewInhabitant { get; set; }
    }
}
