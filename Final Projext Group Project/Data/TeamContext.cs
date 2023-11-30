using Final_Projext_Group_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Projext_Group_Project.Data
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }
        public DbSet<Team> Teams { get; set; }
        //public DbSet<Games> Games { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Tester", Birthdate = "1 January 2023", CollegeProgram = "IT", ProgramYear = "Sophomore" }
                );
        }
    }
}
