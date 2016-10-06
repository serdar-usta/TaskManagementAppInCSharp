using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Entitites;

namespace TaskManagement
{
    public class TaskManContext: DbContext
    {
        public TaskManContext()
            :base("TaskManConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TaskManContext, Migrations.Configuration>());

            // VERİLERİ UÇURUR.......
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TaskManContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<TaskManContext>());
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Entitites.Task> Tasks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
