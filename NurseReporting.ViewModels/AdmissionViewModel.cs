using NurseReporting.DataAccess;
using NurseReporting.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.ViewModels
{
    public class AdmissionViewModel : IAdmissionViewModel
    {
        public DateTime? AcceptedDate { get; set; }

        public DateTime RequestDate { get; set; }

        public DateTime BirthDate { get; set; }

        public int? DayPerWeek { get; set; }

        public Guid EntityId { get; set; }

        public string FirstName { get; set; }

        public DateTime From { get; set; }

        public bool? IsNewInCity { get; set; }

        public bool? IsOutsiteCity { get; set; }

        public string LastName { get; set; }

        public DateTime ReceptionDate { get; set; }

        public string Reference { get; set; }

        public bool Load(Guid entityId)
        {
            using (DataContext dataContext = DataContextFactory.Instance.Create())
            {
                Models.AdmissionRequest admissionRequest = dataContext.AdmissionRequests.FirstOrDefault(c => c.Id == entityId);
                if (admissionRequest != null)
                {
                    AcceptedDate = admissionRequest.AcceptedDate;
                    RequestDate = admissionRequest.RequestDate;
                    BirthDate = admissionRequest.BirthDate;
                    Reference = admissionRequest.RequestNumber;
                    DayPerWeek = admissionRequest.WeeklyRate;
                    FirstName = admissionRequest.FirstName;
                    LastName = admissionRequest.LastName;
                    IsNewInCity = admissionRequest.IsNewInhabitant;
                    IsOutsiteCity = admissionRequest.LivesInMunicipality;
                    ReceptionDate = admissionRequest.ReceptionDate;
                    From = admissionRequest.ForeseenStartDate;
                }

                return true;
            }
        }

        public bool Save()
        {
            using (DataContext dataContext = DataContextFactory.Instance.Create())
            {
                Models.AdmissionRequest admissionRequest = new Models.AdmissionRequest
                {

                    AcceptedDate = AcceptedDate,
                    RequestDate = RequestDate,
                    BirthDate = BirthDate,
                    RequestNumber = Reference,
                    WeeklyRate = DayPerWeek,
                    FirstName = FirstName,
                    LastName = LastName,
                    IsNewInhabitant = IsNewInCity,
                    LivesInMunicipality = IsOutsiteCity,
                    ReceptionDate = ReceptionDate,
                    ForeseenStartDate = From
                };

                dataContext.AdmissionRequests.AddOrUpdate(new[] { admissionRequest });
            }

            return true;
        }
    }
}
