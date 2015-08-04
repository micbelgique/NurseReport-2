using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class Configuration : Entity
    {
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
