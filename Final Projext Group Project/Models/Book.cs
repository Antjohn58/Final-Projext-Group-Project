namespace Final_Projext_Group_Project.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String BookTitle { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public string GetDisplayText() => $"{Id}  {Name} {Book} {Author} {Genre}  ";
    }
}
