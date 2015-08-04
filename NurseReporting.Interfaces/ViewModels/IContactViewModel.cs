using NurseReporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Interfaces.ViewModels
{
    public interface IContactViewModel: IPersistentViewModel
    {        
        string LastName { get; set; }
        string FirstName { get; set; }
        string Mail { get; set; }
        ContactType ContactType { get; set; }
        string Telephone { get; set; }
        string MobilePhone { get; set; }

        Guid Photo { get; set; }
    }
}
