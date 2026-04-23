using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingDemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Content("Hello from MVC HomeController → Index()");
    }
}
