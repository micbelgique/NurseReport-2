using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NurseReporting.Models
{
    public class Contact : Person
    {
        public string FixedPhone { get; set; }

        public string MobilePhone { get; set; }

        public string WorkPhone { get; set; }

        public string Email { get; set; }

        public ContactType ContactType { get; set; }

        public Guid PictureStorageId { get; set; }
    }
}
