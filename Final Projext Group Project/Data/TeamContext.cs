using Final_Projext_Group_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Projext_Group_Project.Data
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }
        public DbSet<Team> Teams { get; set; }
    }
}
