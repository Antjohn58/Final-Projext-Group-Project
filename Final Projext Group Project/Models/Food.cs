namespace Final_Projext_Group_Project.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string favFood { get; set; }
        public string pizzaTop { get; set; }
        public string iceFlavor { get; set; }
        public int mealsPerDay { get; set; }

        public string GetDisplayText() => $"{Id}  {favFood} {pizzaTop} {iceFlavor} {mealsPerDay}  ";

    }
}
