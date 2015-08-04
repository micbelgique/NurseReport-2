using NurseReporting.DataAccess;
using NurseReporting.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace NurseReporting.ViewModels
{
    public class AbsenceViewModel : IAbsenceViewModel
    {
        public DateTime Date { get; set; }

        public Guid EntityId { get; set; }

        public string Comment { get; set; }
        public Models.AbsenceReason Reason { get; set; }

        public IEnumerable<Models.AbsenceReason> Reasons { get; set; }

        public Guid UserID { get; set; }

        public IEnumerable<Guid> ChildIDs { get; set; }

        public bool Load(Guid entityId)
        {
            using (DataContext dataContext = DataContextFactory.Instance.Create())
            {
                Reasons = dataContext.AbsenceReasons.ToList();

                Date = DateTime.Now.Date;
            }

            return true;
        }

        public bool Save()
        {
            using (DataContext dataContext = DataContextFactory.Instance.Create())
            {
                dataContext.Presences.AddRange(ChildIDs.Select(childid =>
                {
                    Models.Presence model = new Models.Presence
                    {
                        AbsenceReason = Reason,
                        Child = dataContext.Children.FirstOrDefault(c => c.Id == childid),
                        Comment = Comment,
                        Date = Date
                    };

                    dataContext.Entry(model).State = EntityState.Unchanged;

                    return model;

                }));
            }

            return true;
        }
    }
}
