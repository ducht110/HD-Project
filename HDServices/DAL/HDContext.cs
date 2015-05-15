using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HDServices.Models;

namespace HDServices.DAL
{
    public class HDContext : DbContext
    {
        public HDContext()
            : base("HDConnectionString")
        {

        }

        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");

        } 
    }
}
