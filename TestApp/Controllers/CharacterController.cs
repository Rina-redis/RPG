using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private static Character charact = new Character();

       // [HttpGet]
        public IActionResult Get()
        {
            return Ok(charact);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
