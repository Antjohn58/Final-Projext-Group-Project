using Final_Projext_Group_Project.Data;
using Final_Projext_Group_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Projext_Group_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        BookContract ctx;
        public BookController(BookContract contract)
        {
            ctx = contract;
        }

        [HttpGet]
        [Route("api/getBooks")]
        public ActionResult Get()
        {
            return Ok(ctx.GetAllBooks());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetBookById(id));
        }

        [HttpPost]
        public IActionResult Post(Book b)
        {
            var result = ctx.AddBook(b);
            if (result == null)
            {
                return StatusCode(500, "A Book with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(Book b)
        {
            var result = ctx.UpdateBook(b);
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
            var book = ctx.GetBookById(id);
            if (book == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveBookById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}

