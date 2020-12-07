using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Best_Hackathon_Codiseea.Models;

namespace Best_Hackathon_Codiseea.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<TeamTask> TeamTasks { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       /* protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TeamTask>().HasData(
              new
              {
                  TeamName = "Test",
                  Value = "Correct",
                  Points = "10",
                  Date = DateTime.Now
              }
            );
        }*/

    }
}
