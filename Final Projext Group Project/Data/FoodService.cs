using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public class FoodService : FoodContract
    {
        FinalContext ctx;
        public FoodService(FinalContext Context)
        {
            ctx = Context;
        }
        public int? AddFood(Food f)
        {
            var food = this.GetFoodById(f.Id);
            if (food != null)
            {
                return null;
            }
            ctx.Foods.Add(f);
            return ctx.SaveChanges();
        }
        public List<Food> GetAllFoods()
        {
            return ctx.Foods.ToList();
        }

        public Food GetFoodById(int Id)
        {
            return ctx.Foods.FirstOrDefault(x => x.Id == Id);
        }
        public int? RemoveFoodbyId(int id)
        {
            var food = this.GetFoodById(id);
            if (food == null)
            {
                return null;
            }
            ctx.Foods.Remove(food);
            return ctx.SaveChanges();
        }

        public int? RemoveFoodById(int id)
        {
            var food = this.GetFoodById(id);
            if (food == null)
            {
                return null;
            }
            ctx.Foods.Remove(food);
            return ctx.SaveChanges();
        }

        public int? UpdateFood(Food f)
        {
            ctx.Foods.Update(f);
            return ctx.SaveChanges();
        }
    }
}
