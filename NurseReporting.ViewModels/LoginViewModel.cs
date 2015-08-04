using NurseReporting.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.ViewModels
{
    public class LoginViewModel : ILoginViewModel
    {
        public string Password { get; set; }

        public string UserName { get; set; }

    }
}
