using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

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

            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        }
    }
}
