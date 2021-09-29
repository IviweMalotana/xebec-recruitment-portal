using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Configurations.Entities;
using XebecPortal.Shared;

namespace Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<AdditionalInformation> AdditionalInformations { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationPhase> ApplicationPhases { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentHelper> DocumentHelpers { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationHelper> EducationHelpers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<JobTypeHelper> JobTypeHelpers { get; set; }
        public DbSet<LoginHelper> LoginHelpers { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<RegisterHelper> RegisterHelpers { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkHistory> WorkHistories { get; set; }
        public DbSet<WorkHistoryHelper> WorkHistoryHelpers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.ApplyConfiguration(new JobConfiguration());

            modelBuilder.ApplyConfiguration(new PersonalInformationConfiguration());

        }

    }
}