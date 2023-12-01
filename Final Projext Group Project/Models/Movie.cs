namespace Final_Projext_Group_Project.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Stream { get; set; }

        public string GetDisplayText() => $"{Id}  {MovieTitle} {ReleaseYear} {Genre} {Stream}  ";
    }
}
