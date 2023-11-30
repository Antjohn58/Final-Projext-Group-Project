using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public interface GameContract
    {
        int? AddGame(Games i);
        List<Games> GetAllGames();
        Games GetGamesById(int Id);
        int? RemoveGamesById(int id);
        int? UpdateGames(Games i);
    }
}
