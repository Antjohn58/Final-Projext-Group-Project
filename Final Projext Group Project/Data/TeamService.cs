using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public class TeamService: TeamContract
    {
            TeamContext ctx;
            public TeamService(TeamContext Context)
            {
                ctx = Context;
            }

            public int? AddItem(Team i)
            {
                throw new NotImplementedException();
            }

        public int? AddTeam(Team i)
        {
            throw new NotImplementedException();
        }

        public int? AddProduct(Team i)
            {
                var product = this.GetTeamById(i.PersonID);
                if (product != null)
                {
                    return null;
                }
                ctx.Teams.Add(i);
                return ctx.SaveChanges();
            }
            public List<Team> GetAllTeam()
            {
                return ctx.Teams.ToList();
            }

            public Team GetTeamById(int Id)
            {
                return ctx.Teams.FirstOrDefault(x => x.PersonID == Id);
            }

        List<Team> TeamContract.GetAllTeams()
        {
            throw new NotImplementedException();
        }

        Team TeamContract.GetTeamById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
