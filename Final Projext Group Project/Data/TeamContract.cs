using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public interface TeamContract
    {
        int? AddItem(Team i);
        List<Team> GetAllTeams();
        Team GetTeamById(int Id);
    }
}
