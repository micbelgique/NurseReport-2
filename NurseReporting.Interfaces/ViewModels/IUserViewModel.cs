using NurseReporting.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Interfaces.ViewModels
{
    public interface IUserViewModel : IPersistentViewModel
    {
        string UserName { get; set; }
        string Password { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string Mail { get; set; }
        string Language { get; set; }
        IEnumerable<string> Languages { get; set; }
        bool IsEnabled { get; set; }
        Role Role { get; set; }
        long ContactID { get; set; }
        string ContactLastName { get; set; }
        string ContactFirstName { get; set; }
    }
}
