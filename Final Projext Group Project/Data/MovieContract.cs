using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public interface MovieContract
    {
        int? AddMovie(Movie m);
        List<Movie> GetAllMovies();
        Movie GetMovieById(int Id);
        int? RemoveMovieById(int id);
        int? UpdateMovie(Movie m);
    }
}
