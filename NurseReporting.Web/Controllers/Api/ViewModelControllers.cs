using NurseReporting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NurseReporting.Web.Controllers.Api
{
    public class ContactController : ViewModelControllerBase<ContactViewModel> { }

    public class AbsenceController : ViewModelControllerBase<AbsenceViewModel> { }

    public class DashBoardController : ViewModelControllerBase<DashBoardViewModel> { }

    public class AdmissionController : ViewModelControllerBase<AdmissionViewModel> { }

    public class ChildCardController : ViewModelControllerBase<ChildCardViewModel> { }

    public class DailyObservationController : ViewModelControllerBase<DailyObservationViewModel> { }

    public class PresenceController : ViewModelControllerBase<PresenceViewModel> { }
}
