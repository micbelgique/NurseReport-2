using NurseReporting.Interfaces.ViewModels;
using NurseReporting.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.ViewModels
{
    public class UserViewModel : IUserViewModel
    {
        public string ContactFirstName { get; set; }

        public long ContactID { get; set; }

        public string ContactLastName { get; set; }

        public Guid EntityId { get; set; }

        public string FirstName { get; set; }

        public bool IsEnabled { get; set; }

        public string Language { get; set; }

        public IEnumerable<string> Languages { get; set; }

        public string LastName { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

        public string UserName { get; set; }

        public bool Load(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
