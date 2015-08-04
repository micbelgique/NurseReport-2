using NurseReporting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.DataAccess
{
    public class DataContext : DbContext, IDisposable
    {
        internal DataContext()
            : base("NurseReporting")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                this.SaveChanges();
                base.Dispose(disposing);
            }
            catch (EntityException ex)
            {
            }
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Contact>().Property(c => c.Email).HasColumnAnnotation(
        //            IndexAnnotation.AnnotationName,
        //            new IndexAnnotation(
        //                new IndexAttribute("IX_EmailUnique", 1) { IsUnique = true }));
        //}

        public DbSet<Activity> Activities { get; set; }

        public DbSet<ActivityType> ActivityTypes { get; set; }

        public DbSet<AdmissionRequest> AdmissionRequests { get; set; }

        public DbSet<Allergy> Allergies { get; set; }

        public DbSet<Child> Children { get; set; }

        public DbSet<Configuration> Configurations { get; set; }

        public DbSet<ContactType> ContactTypes { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<DayEvent> DayEvents { get; set; }

        public DbSet<DayFile> DayFiles { get; set; }

        public DbSet<EventType> EventTypes { get; set; }

        public DbSet<Nurse> Nurses { get; set; }

        public DbSet<AbsenceReason> AbsenceReasons { get; set; }

        public DbSet<Presence> Presences { get; set; }

        public DbSet<Section> Sections { get; set; }
    }
}
