using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingDemo.Controllers;

public class OrdersController : Controller
{
    public IActionResult Index()
    {
        return Content("Orders → Index()");
    }

    public IActionResult Status(int? id)
    {
        if (id == null)
            return Content("Orders → Status() → No ID provided");

        return Content($"Orders → Status({id})");
    }
}
