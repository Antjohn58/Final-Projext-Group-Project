using Final_Projext_Group_Project.Data;
using Final_Projext_Group_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Projext_Group_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {

            TeamContract ctx;
            public TeamController(TeamContract contract)
            {
                ctx = contract;
            }
            [HttpGet]
            public ActionResult Get()
            {
                return Ok(ctx.GetAllTeams());
            }


            [HttpPost]
            public IActionResult Post(Team i)
            {
                var result = ctx.AddTeam(i);
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

        }
    }
    
