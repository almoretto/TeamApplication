using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;
using TeamApplication.Models;

namespace TeamApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //     #warning To protect potentially sensitive information in your connection string, 
            // you should move it out of source code.See http://go.microsoft.com/fwlink/?LinkId=723263 
            //   for guidance on storing connection strings.

            optionsBuilder.UseMySQL("server=localhost;database=TeamAppDB;user=root;password=");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamSchedule> TeamSchedule { get; set; }
        public DbSet<TeamVolunteer> TeamVolunteer { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }

    }
}
