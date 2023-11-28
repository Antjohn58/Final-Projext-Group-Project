namespace Final_Projext_Group_Project.Models
{
    public class FoodPalette
    {
        public int PersonID { get; set; }
        public string favFood { get; set; }
        public string pizzaTop { get; set; }
        public string iceFlavor { get; set; }
        public int mealsPerDay { get; set; }

        public string GetDisplayText() => $"{PersonID}  {favFood} {pizzaTop} {iceFlavor} {mealsPerDay}  ";

    }
}
