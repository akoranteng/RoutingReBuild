using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingDemo.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {// GET: /admin
        [HttpGet("")]
        public IActionResult Index()
        {
            return Content("Admin → Index()");
        }

        // GET: /admin/users/2
        // for above attribute routing, use the Attribute routing 
        //per below
        [HttpGet("users/{id:int}")]
        public IActionResult UserDetails(int id)
        {
            return Content($"Admin → UserDetails({id})");
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            return Content("Admin → Dashboard()");
        }
        [HttpGet("users")]
        public IActionResult Users()
        {
            return Content("Admin → Users()");
        }
        [HttpGet("reports")]
        public IActionResult Reports()
        {
            return Content("Admin → Reports()");
        }

        [HttpGet("settings")]
        public IActionResult Settings()
        {
            return Content("Admin → Settings()");
        }

        [HttpGet("logs/{date?}")]
        public IActionResult Logs(string? date)
        {
            return Content($"Admin → Logs({date ?? "no date"})");
        }





    }
}
