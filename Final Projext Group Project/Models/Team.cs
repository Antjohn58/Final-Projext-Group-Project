namespace Final_Projext_Group_Project.Models
{
    public class Team
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string GetDisplayText() => $"{PersonID}  {Name}  {Description} ({Price:c})";
    }
}
