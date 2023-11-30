using Final_Projext_Group_Project.Data;
using Final_Projext_Group_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Projext_Group_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : Controller
    {
        GameContract ctx;
        public GameController(GameContract contract)
        {
            ctx = contract;
        }

        [HttpGet]
        [Route("api/getproducts")]
        public ActionResult Get()
        {
            return Ok(ctx.GetAllGames());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetGameById(id));
        }

        [HttpPost]
        public IActionResult Post(Game g)
        {
            var result = ctx.AddGame(g);
            if (result == null)
            {
                return StatusCode(500, "A Product with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(Game g)
        {
            var result = ctx.UpdateGame(g);
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
            var game = ctx.GetGameById(id);
            if (game == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveGameById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
