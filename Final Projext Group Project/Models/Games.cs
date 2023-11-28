namespace Final_Projext_Group_Project.Models
{
    public class Games
    {
        public string PlayerName { get; set; }
        public string GameTitle { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string System { get; set; }

        public string GetDisplayText() => $"{PlayerName}  {GameTitle} {ReleaseYear} {Genre} {System}  ";
    }
}
