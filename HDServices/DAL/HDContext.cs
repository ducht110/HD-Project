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

        // main entities.
        public DbSet<Content> Contents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<NewsCategory> NewsCategorys { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Page> Pages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // main entities.
            modelBuilder.Entity<Content>().ToTable("Content");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<NewsCategory>().ToTable("NewsCategory");
            modelBuilder.Entity<News>().ToTable("News");
            modelBuilder.Entity<Page>().ToTable("Page");

            modelBuilder.Entity<User>()
                  .HasMany<Role>(s => s.Roles)
                  .WithMany(c => c.Users)
                  .Map(cs =>
                  {
                      cs.MapLeftKey("UserID");
                      cs.MapRightKey("RoleID");
                      cs.ToTable("UserRole");
                  });

            //one-to-many 
            modelBuilder.Entity<NewsCategory>()
                        .HasMany<News>(s => s.NewsList)
                        .WithRequired(s => s.NewsCategory)
                        .HasForeignKey(s => s.NewsCategoryID);

            //one-to-many  
            modelBuilder.Entity<Page>()
                        .HasOptional<Content>(s => s.Content)
                        .WithMany(s => s.Pages)
                        .HasForeignKey(s => s.ContentID);


            //seft reference 
            modelBuilder.Entity<Page>().HasOptional(p => p.Parent).WithMany(p => p.Children).HasForeignKey(t => t.ParentID);


        }
    }
}
