namespace Final_Projext_Group_Project.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Birthdate {  get; set; }
        public string CollegeProgram { get; set; }
        public string ProgramYear { get; set; }

        public string GetDisplayText() => $"{Id}  {Name} {Birthdate} {CollegeProgram} {ProgramYear}  ";
    }
}
