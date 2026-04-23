📘 MvcRoutingDemo — ASP.NET Core MVC Routing Module
This project demonstrates ASP.NET Core MVC routing fundamentals, including conventional routing, attribute routing, route parameters, optional segments, constraints, and controller/action discovery. It is part of the RoutingReBuild solution and serves as the dedicated module for teaching MVC routing concepts.
🎯 Learning Objectives
By the end of this module, learners will understand:

How MVC routing works in ASP.NET Core

The difference between conventional routing and attribute routing
How controllers and actions are mapped to URLs

How to use route parameters, optional parameters, and constraints

How to organize routes cleanly for real‑world applications

MvcRoutingDemo/
│
├── Controllers/
│   ├── HomeController.cs
│   ├── AdminController.cs
│   ├── ProductsController.cs
│   ├── OrdersController.cs
│   └── BlogController.cs
│
├── Program.cs
├── appsettings.json
└── README.md   ← (this file)
Each controller demonstrates a different routing scenario.

🚦 Routing Configuration (Program.cs
The project uses conventional routing with the standard MVC pattern:
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

    This means:

/ → HomeController.Index

/Products/List → ProductsController.List

/Orders/Details/5 → OrdersController.Details(5)

🧭 Attribute Routing Examples
Several controllers use attribute routing to demonstrate more advanced patterns.

ProductsController
csharp
[Route("products")]
public class ProductsController : Controller
{
    [HttpGet("")]
    public IActionResult Index()

    [HttpGet("{id:int}")]
    public IActionResult Details(int id)
}

BlogController
[Route("blog")]
public class BlogController : Controller
{
    [HttpGet("{year:int}/{month:int}/{slug}")]
    public IActionResult Post(int year, int month, string slug)
🛠 Controllers Included
Controller	Purpose
HomeController	Basic landing routes
AdminController	Demonstrates admin‑area style routing
ProductsController	Attribute routing + constraints
OrdersController	Conventional routing with parameters
BlogController	Multi‑segment attribute routing

🧪 How to Run the Demo
Set MvcRoutingDemo as the startup project

Run the application

Test routes such as:

Code
/Home/Index
/Products
/Products/3
/Orders/Details/10
/blog/2024/04/intro-to-routing






    
}


    






