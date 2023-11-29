using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public class TeamService : TeamContract
    {
        TeamContext ctx;
        public TeamService(TeamContext Context)
        {
            ctx = Context;
        }
        public int? AddTeam(Team i)
        {
            var team = this.GetTeamById(i.Id);
            if (team != null)
            {
                return null;
            }
            ctx.Teams.Add(i);
            return ctx.SaveChanges();
        }
        public List<Team> GetAllTeams()
        {
            return ctx.Teams.ToList();
        }

        public Team GetTeamById(int Id)
        {
            return ctx.Teams.FirstOrDefault(x => x.Id == Id);
        }
        public int? RemoveTeambyId(int id)
        {
            var team = this.GetTeamById(id);
            if (team == null)
            {
                return null;
            }
            ctx.Teams.Remove(team);
            return ctx.SaveChanges();
        }

        public int? RemoveTeamById(int id)
        {
            var team = this.GetTeamById(id);
            if (team == null)
            {
                return null;
            }
            ctx.Teams.Remove(team);
            return ctx.SaveChanges();
        }

        public int? UpdateProduct(Team i)
        {
            ctx.Teams.Update(i);
            return ctx.SaveChanges();
        }

        public int? UpdateTeam(Team i)
        {
            throw new NotImplementedException();
        }
    }
}

