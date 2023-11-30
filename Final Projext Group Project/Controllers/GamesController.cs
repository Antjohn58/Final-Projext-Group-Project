using Microsoft.AspNetCore.Mvc;

namespace Final_Projext_Group_Project.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
