using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public interface FoodContract
    {
        int? AddFood(Food f);
        List<Food> GetAllFoods();
        Food GetFoodById(int Id);
        int? RemoveFoodById(int id);
        int? UpdateFood(Food f);
    }
}