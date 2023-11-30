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
        public int? AddFood(Food i)
        {
            var food = this.GetFoodById(i.PersonID);
            if (food != null)
            {
                return null;
            }
            ctx.Foods.Add(i);
            return ctx.SaveChanges();
        }
        public List<Food> GetAllFoods()
        {
            return ctx.Foods.ToList();
        }

        public Food GetFoodById(int Id)
        {
            return ctx.Foods.FirstOrDefault(x => x.PersonID == Id);
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

        public int? UpdateProduct(Food i)
        {
            ctx.Foods.Update(i);
            return ctx.SaveChanges();
        }

        public int? UpdateFood(Food i)
        {
            throw new NotImplementedException();
        }
    }
}
