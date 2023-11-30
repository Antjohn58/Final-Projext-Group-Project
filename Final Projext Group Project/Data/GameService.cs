using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public class GameService : GameContract
    {
        FinalContext ctx;
        public GameService(FinalContext Context)
        {
            ctx = Context;
        }
        public int? AddGame(Game g)
        {
            var game = this.GetGameById(g.Id);
            if (game != null)
            {
                return null;
            }
            ctx.Games.Add(g);
            return ctx.SaveChanges();
        }
        public List<Game> GetAllGames()
        {
            return ctx.Games.ToList();
        }

        public Game GetGameById(int Id)
        {
            return ctx.Games.FirstOrDefault(x => x.Id == Id);
        }
        public int? RemoveTeambyId(int id)
        {
            var game = this.GetGameById(id);
            if (game == null)
            {
                return null;
            }
            ctx.Games.Remove(game);
            return ctx.SaveChanges();
        }

        public int? RemoveGameById(int id)
        {
            var game = this.GetGameById(id);
            if (game == null)
            {
                return null;
            }
            ctx.Games.Remove(game);
            return ctx.SaveChanges();
        }

        public int? UpdateGame(Game g)
        {
            ctx.Games.Update(g);
            return ctx.SaveChanges();
        }

    }
}

