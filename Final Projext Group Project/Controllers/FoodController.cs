using Final_Projext_Group_Project.Data;
using Final_Projext_Group_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Projext_Group_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : Controller
    {
        FoodContract ctx;
        public FoodController(FoodContract contract)
        {
            ctx = contract;
        }

        [HttpGet]
        [Route("api/getproducts")]
        public ActionResult Get()
        {
            return Ok(ctx.GetAllFoods());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetFoodById(id));
        }

        [HttpPost]
        public IActionResult Post(Food f)
        {
            var result = ctx.AddFood(f);
            if (result == null)
            {
                return StatusCode(500, "A Food with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(Food f)
        {
            var result = ctx.UpdateFood(f);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var product = ctx.GetFoodById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveFoodById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
