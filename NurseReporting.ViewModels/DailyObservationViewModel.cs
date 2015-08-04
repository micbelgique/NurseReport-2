using NurseReporting.DataAccess;
using NurseReporting.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.ViewModels
{
    public class DailyObservationViewModel : IDailyObservableViewModel
    {
        public string LunchComment { get; set; }
        public int LunchRating { get; set; }
        public string SnackComment { get; set; }
        public int SnackRating { get; set; }
        public DateTime? NapFrom { get; set; }
        public DateTime? NapTo { get; set; }
        public bool IsNapRestless { get; set; }
        public bool IsNapNormal { get; set; }
        public string NapComment { get; set; }
        public string PoohComment { get; set; }
        public string ObservationComment { get; set; }

        public Guid EntityId { get; set; }

        public bool Load(Guid entityId)
        {
            using (DataContext dataContext = DataContextFactory.Instance.Create())
            {
                Models.Activity activity = dataContext.Activities.FirstOrDefault(c => c.Id == entityId);
                if (activity != null)
                {
                    
                }
            }

            return true;
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
