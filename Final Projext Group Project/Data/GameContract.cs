using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public interface GameContract
    {
        int? AddGame(Game g);
        List<Game> GetAllGames();
        Game GetGameById(int Id);
        int? RemoveGameById(int id);
        int? UpdateGame(Game g);
    }
}
