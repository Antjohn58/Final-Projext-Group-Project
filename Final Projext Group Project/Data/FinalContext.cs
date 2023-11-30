using Final_Projext_Group_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Projext_Group_Project.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Food> Foods{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Tester", Birthdate = "1 January 2023", CollegeProgram = "IT", ProgramYear = "Sophomore" }
                );
        }
    }
}
