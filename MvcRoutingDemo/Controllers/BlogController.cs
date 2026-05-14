using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingDemo.Controllers;

//Implement attribute routing
[Route("blog")]
public class BlogController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return Content("Blog → Index()");
    }

    [HttpGet("{year}/{month}/{slug}")]  //Action level tempalates
    public IActionResult Post(int year, int month, string slug)
    {
        return Content($"Blog → {year}/{month}/{slug}");
    }


    [Route("admin")]
    public class AdminController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return Content("Admin → Index()");
        }

        [HttpGet("users/{id:int}")]
        public IActionResult UserDetails(int id)
        {
            return Content($"Admin → UserDetails({id})");
        }
    }


}
