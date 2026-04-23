using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingDemo.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        return Content("Products → Index()");
    }

    public IActionResult Details(int? id)
    {
        if (id == null)
            return Content("Products → Details() → No ID provided");

        return Content($"Products → Details({id})");
    }
}
