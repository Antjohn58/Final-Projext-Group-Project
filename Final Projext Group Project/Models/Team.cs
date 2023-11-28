namespace Final_Projext_Group_Project.Models
{
    public class Team
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Birthdate {  get; set; }
        public string CollegeProgram { get; set; }
        public string ProgramYear { get; set; }

        public string GetDisplayText() => $"{PersonID}  {Name} {Birthdate} {CollegeProgram} {ProgramYear}  ";
    }
}
