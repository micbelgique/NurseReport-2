using NurseReporting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.DataAccess
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        public override void InitializeDatabase(DataContext context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(DataContext context)
        {
#if DEBUG
            var absenceReasons = new List<AbsenceReason>
            {
                new AbsenceReason { Label = "Maladie", IsBillable = false },
                new AbsenceReason { Label = "Injustifié", IsBillable = true },
                new AbsenceReason { Label = "Aucune", IsBillable = true }
            };

            context.AbsenceReasons.AddRange(absenceReasons);

            var activityTypes = new List<ActivityType>
            {
                new ActivityType { Name = "Psychomotricité", DefaultComment = "" },
                new ActivityType { Name = "Pédiatre", DefaultComment = "" },
                new ActivityType { Name = "Photographe", DefaultComment = "" },
                new ActivityType { Name = "Chasse aux oeufs", DefaultComment = "" },
                new ActivityType { Name = "Promenade", DefaultComment = "" },
                new ActivityType { Name = "Autre", DefaultComment = "" }
            };

            context.ActivityTypes.AddRange(activityTypes);

            var allergies = new List<Allergy>
            {
                new Allergy { Name = "Allergie 1" },
                new Allergy { Name = "Allergie 2" },
                new Allergy { Name = "Allergie 3" },
                new Allergy { Name = "Allergie 4" }
            };

            context.Allergies.AddRange(allergies);


            var contactTypes = new List<ContactType>
            {
                new ContactType { IsResponsibleForChild = true, Label = "Mère" },
                new ContactType { IsResponsibleForChild = true, Label = "Père" },
                new ContactType { IsResponsibleForChild = false, Label = "Soeur" },
                new ContactType { IsResponsibleForChild = false, Label = "Frère" },
                new ContactType { IsResponsibleForChild = false, Label = "Grand-père" },
                new ContactType { IsResponsibleForChild = false, Label = "Grand-mère" },
                new ContactType { IsResponsibleForChild = false, Label = "Oncle" },
                new ContactType { IsResponsibleForChild = false, Label = "Tante" },
                new ContactType { IsResponsibleForChild = true, Label = "Tuteur légal" },
                new ContactType { IsResponsibleForChild = false, Label = "Autre" }
            };

            context.ContactTypes.AddRange(contactTypes);

            var contacts = new List<Contact>
            {
                new Contact { ContactType = contactTypes[1], Email = "nurse@nurse.com", LastName = "House" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[0], Email = "parent@nurse.com", LastName = "Peeters" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[1], Email = "Parent1@nurse.com", LastName = "Janssens" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[2], Email = "Parent1@nurse.com", LastName = "Maes" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[3], Email = "Parent1@nurse.com", LastName = "Jacobs" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[5], Email = "Parent1@nurse.com", LastName = "Mertens" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[1], Email = "Parent1@nurse.com", LastName = "Willems" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[6], Email = "Parent1@nurse.com", LastName = "Claes" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[8], Email = "Parent1@nurse.com", LastName = "Goossens" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[4], Email = "Parent1@nurse.com", LastName = "Wouters" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[3], Email = "Parent1@nurse.com", LastName = "De Smet" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[5], Email = "Parent1@nurse.com", LastName = "Dubois" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[1], Email = "Parent1@nurse.com", LastName = "Lambert" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[6], Email = "Parent1@nurse.com", LastName = "Dupont" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[8], Email = "Parent1@nurse.com", LastName = "Martin" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
                new Contact { ContactType = contactTypes[4], Email = "Parent1@nurse.com", LastName = "Simon" , FixedPhone = "+3271141414", Id = Guid.NewGuid(), FirstName = "Manu",MobilePhone = "+32474111111", PictureStorageId = Guid.NewGuid(), WorkPhone = "+32444444" },
            };

            context.Contacts.AddRange(contacts);

            var children = new List<Child>
            {
                new Child { Allergies = null, BirthDate = new DateTime(2014,5,28),  Contacts = new [] { contacts[0], contacts[1]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Louis", Id = Guid.NewGuid(),LastName = "Vanderhelstt" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,5,28),  Contacts = new [] {contacts[0],contacts[2]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Victor", Id = Guid.NewGuid(),LastName = "Hazard" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,5,28),  Contacts = new [] {contacts[0],contacts[3]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Lea", Id = Guid.NewGuid(),LastName = "Peeters" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,5,1),   Contacts = new [] {contacts[0],contacts[4]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Lucie", Id = Guid.NewGuid(),LastName = "Jacobs" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,5,12),  Contacts = new [] {contacts[0],contacts[5]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Zoe", Id = Guid.NewGuid(),LastName = "Claes" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,5,3),   Contacts = new [] {contacts[0],contacts[6]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Emma", Id = Guid.NewGuid(),LastName = "Willems" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,5,5),   Contacts = new [] {contacts[0],contacts[7]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Charles", Id = Guid.NewGuid(),LastName = "Mertens" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,7,5),   Contacts = new [] {contacts[0],contacts[8]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Manu", Id = Guid.NewGuid(),LastName = "De Smet" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,8,10),  Contacts = new [] {contacts[0],contacts[9]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Jean-Phillipe", Id = Guid.NewGuid(),LastName = "Dupont" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,4,30),  Contacts = new [] {contacts[0],contacts[10]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Yves", Id = Guid.NewGuid(),LastName = "Clerbois" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,4,30),  Contacts = new [] {contacts[0],contacts[11]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Adrien", Id = Guid.NewGuid(),LastName = "Cotton" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,8,13),  Contacts = new [] {contacts[0],contacts[12]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Marc", Id = Guid.NewGuid(),LastName = "Dupond" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,8,14),  Contacts = new [] {contacts[0],contacts[13]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Andre", Id = Guid.NewGuid(),LastName = "Martin" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,9,15),  Contacts = new [] {contacts[0],contacts[14]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Luc", Id = Guid.NewGuid(),LastName = "Lambert" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,9,16),  Contacts = new [] {contacts[0],contacts[15]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Michel", Id = Guid.NewGuid(),LastName = "Dubois" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,9,17),  Contacts = new [] {contacts[0],contacts[1]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Stephanie", Id = Guid.NewGuid(),LastName = "Dejaeger" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,9,12),  Contacts = new [] {contacts[2]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Aurelie", Id = Guid.NewGuid(),LastName = "Hessel" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,9,13),  Contacts = new [] {contacts[3]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Bastien", Id = Guid.NewGuid(),LastName = "Simon" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,9,14),  Contacts = new [] {contacts[0],contacts[4]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Stephane", Id = Guid.NewGuid(),LastName = "Van de zout" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,9,15),  Contacts = new [] {contacts[0],contacts[5]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Marieke", Id = Guid.NewGuid(),LastName = "Janssens" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,9,16),  Contacts = new [] {contacts[0],contacts[6]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Jesus", Id = Guid.NewGuid(),LastName = "LaMaison" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,10,11), Contacts = new [] {contacts[0],contacts[7]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Georges", Id = Guid.NewGuid(),LastName = "Lambert" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,10,10), Contacts = new [] {contacts[0],contacts[8]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Mickael", Id = Guid.NewGuid(),LastName = "Jackson" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,10,12), Contacts = new [] {contacts[0],contacts[9]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Denis", Id = Guid.NewGuid(),LastName = "Voix" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,10,12), Contacts = new [] {contacts[0],contacts[10]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Matthieu", Id = Guid.NewGuid(),LastName = "Renard" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,10,13), Contacts = new [] {contacts[0],contacts[11]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Renaud", Id = Guid.NewGuid(),LastName = "Lamer" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,10,14), Contacts = new [] {contacts[0],contacts[12]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Marie", Id = Guid.NewGuid(),LastName = "Joseph" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,11,11), Contacts = new [] {contacts[0],contacts[13]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Julie", Id = Guid.NewGuid(),LastName = "Lagarde" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,11,12), Contacts = new [] {contacts[0],contacts[14]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Marion", Id = Guid.NewGuid(),LastName = "Cotilliard" ,Section = null, StartDate =new DateTime(2015,07,07)  },
                new Child { Allergies = null, BirthDate = new DateTime(2014,11,13), Contacts = new [] {contacts[0],contacts[15]}, EndDate = null, EstimatedEndDate = new DateTime(2015,10,10), FirstName = "Ovidie", Id = Guid.NewGuid(),LastName = "Lagrande" ,Section = null, StartDate =new DateTime(2015,07,07)  },
            };

            context.Children.AddRange(children);



            var eventTypes = new List<EventType>
            {
                new EventType { Name = "Welcome", Label = "Accueil" },
                new EventType { Name = "Lunch", Label = "Repas de midi" },
                new EventType { Name = "Snack", Label = "Collation" },
                new EventType { Name = "Sleep", Label = "Sieste" },
                new EventType { Name = "Stools", Label = "Selles" },
                new EventType { Name = "Observations", Label = "Observations" }
            };

            context.EventTypes.AddRange(eventTypes);

            context.SaveChanges();
#endif
        }
    }
}
