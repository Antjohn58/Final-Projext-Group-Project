using Microsoft.EntityFrameworkCore;

namespace Final_Projext_Group_Project.Data
{
    public class TeamContext:DbContext
    {
    public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }
    public DbSet<Team> Items { get; set; }
}
}
