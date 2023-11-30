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
        public int? AddGame(Games i)
        {
            var game = this.GetGamesById(i.Id);
            if (game != null)
            {
                return null;
            }
            ctx.Games.Add(i);
            return ctx.SaveChanges();
        }
        public List<Games> GetAllGames()
        {
            return ctx.Games.ToList();
        }

        public Games GetGamesById(int Id)
        {
            return ctx.Games.FirstOrDefault(x => x.Id == Id);
        }
        public int? RemoveGamesbyId(int id)
        {
            var game = this.GetGamesById(id);
            if (game == null)
            {
                return null;
            }
            ctx.Games.Remove(game);
            return ctx.SaveChanges();
        }

        public int? RemoveGamesById(int id)
        {
            var game = this.GetGamesById(id);
            if (game == null)
            {
                return null;
            }
            ctx.Games.Remove(game);
            return ctx.SaveChanges();
        }

        public int? UpdateProduct(Games i)
        {
            ctx.Games.Update(i);
            return ctx.SaveChanges();
        }

        public int? UpdateGames(Games i)
        {
            throw new NotImplementedException();
        }
    }
}

