using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
	public class KarbilContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            //optionsBuilder.UseMySql(@"Server=localhost; database=karbil; uid=root; pwd=k7RBS7oRTJ2ibryo", serverVersion);
            optionsBuilder.UseMySql(@"Server=localhost; database=km; uid=root; pwd=1513", serverVersion);

        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<ContactForm> ContactForm { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<Counters> Counters { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<LastProject> LastProject { get; set; }
        public DbSet<Processes> Processes { get; set; }
        public DbSet<ProcessesImages> ProcessesImages { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProjectSteps> ProjectSteps { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<News> News { get; set; }


        public DbSet<RequestFeature> RequestFeature { get; set; }
        public DbSet<SSS> SSS { get; set; }
        public DbSet<User> User { get; set; }

    }
}

