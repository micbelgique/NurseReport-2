using NurseReporting.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NurseReporting.Models;
using NurseReporting.DataAccess;
using System.Data.Entity.Migrations;

namespace NurseReporting.ViewModels
{
    public class ChildCardViewModel : IChildCardViewModel
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Allergy> Allergies { get; set; }
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }

        public Guid EntityId { get; set; }

        public bool Load(Guid entityId)
        {
            using (DataContext datacontext = DataContextFactory.Instance.Create())
            {
                Child child = datacontext.Children.FirstOrDefault(c => c.Id == entityId);
                if (child != null)
                {
                    EntityId = entityId;          
                    FirstName = child.FirstName;
                    LastName = child.LastName;
                    BirthDate = child.BirthDate;
                    StartDate = child.StartDate;
                    EndDate = child.EndDate;                    
                }
            }
            return true;
        }

        public bool Save()
        {
            using (DataContext dataContext = DataContextFactory.Instance.Create())
            {
                var child = dataContext.Children.FirstOrDefault(c => c.Id == EntityId);

                if(child != null)
                {
                    child.StartDate = StartDate;
                    child.EndDate = EndDate;
                    child.FirstName = FirstName;
                    child.LastName = LastName;
                    child.BirthDate = BirthDate;
                    child.EstimatedEndDate = EstimatedEndDate;
                }
                else
                {
                    child = new Child
                {
                    Id = EntityId,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    FirstName = FirstName,
                    LastName = LastName,
                    BirthDate = BirthDate,
                    EstimatedEndDate = EstimatedEndDate                  
                };
                }
                
                dataContext.Children.AddOrUpdate(new[] { child });
            }
            return true;
        }
    }
}