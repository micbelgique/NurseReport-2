using System.Data.Entity.Migrations;
using NurseReporting.DataAccess;
using NurseReporting.Interfaces.ViewModels;
using NurseReporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.ViewModels
{
    public class ContactViewModel : IContactViewModel
    {
        public Guid EntityId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ContactType ContactType { get; set; }

        public string Mail { get; set; }

        public string MobilePhone { get; set; }

        public Guid Photo { get; set; }

        public string Telephone { get; set; }

        public bool Load(Guid entityId)
        {
            using (DataContext dataContext = DataContextFactory.Instance.Create())
            {
                Contact contact = dataContext.Contacts.FirstOrDefault(c => c.Id == entityId);
                if (contact != null)
                {
                    FirstName = contact.FirstName;
                    LastName = contact.LastName;
                    ContactType = contact.ContactType;
                    Mail = contact.Email;
                    MobilePhone = contact.MobilePhone;
                    Telephone = contact.FixedPhone;
                }
            }

            return true;
        }

        public bool Save()
        {
            using (DataContext dataContext = DataContextFactory.Instance.Create())
            {
                Contact contact = dataContext.Contacts.FirstOrDefault(c => c.Id == EntityId);

                if(contact != null)
                {
                    contact.ContactType = ContactType;
                    contact.Email = Mail;
                    contact.FirstName = FirstName;
                    contact.LastName = LastName;
                    contact.FixedPhone = Telephone;
                    contact.MobilePhone = MobilePhone;
                    contact.PictureStorageId = Photo;
                }
                else
                {
                    contact = new Contact
                    {
                        Id = EntityId,
                        ContactType = ContactType,
                        Email = Mail,
                        FirstName = FirstName,
                        LastName = LastName,
                        FixedPhone = Telephone,
                        MobilePhone = MobilePhone,
                        PictureStorageId = Photo
                    };
                }
                dataContext.Contacts.AddOrUpdate(new[] { contact });
            }

            return true;
        }
    }
}
