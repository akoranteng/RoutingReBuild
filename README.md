📘 RazorPagesRoutingDemo — ASP.NET Core Razor Pages Routing Module
This module demonstrates how routing works in ASP.NET Core Razor Pages, including page-based routing, folder conventions, route parameters, optional segments, and handler methods. It is part of the RoutingReBuild curriculum and serves as the dedicated module for teaching Razor Pages routing concepts.

🎯 Learning Objectives
By the end of this module, learners will understand:

How Razor Pages routing works in ASP.NET Core

How the @page directive defines routes

How folder structure influences routing

How to use route parameters and optional segments

How to implement handler methods (OnGet, OnPost, etc.)

How Razor Pages routing compares to MVC routing

🏗 Project Structure
RazorPagesRoutingDemo/
│
├── Pages/
│   ├── Index.cshtml
│   ├── Products/
│   │   ├── Index.cshtml
│   │   └── Details.cshtml
│   ├── Blog/
│   │   └── Post.cshtml
│   └── Shared/
│
├── wwwroot/
├── appsettings.json
├── Program.cs
└── README.md   ← (this file)

🚦 Razor Pages Routing Basics
Razor Pages uses page-based routing, where each .cshtml file becomes an endpoint.

Example: Basic Page Route
@page
<h1>Home Page</h1>
This maps to:  /

🧭 Route Parameters

Example: Product Details Page
Pages/Products/Details.cshtml:
@page "{id:int}"
@model DetailsModel

<h2>Product Details for @Model.Id</h2>
This maps to:

Code
/Products/Details/5****
🧩 Optional Segments
@page "{year:int}/{month:int?}"
Examples:
/2024
/2024/04

🛠 Handler Methods
Razor Pages uses handler methods instead of controllers.
public class IndexModel : PageModel
{
    public void OnGet() { }

    public IActionResult OnPost()
    {
        return RedirectToPage("Success");
    }
}

📝 Comparison: Razor Pages vs MVC Routing

| Feature | Razor Pages | MVC |
| --- | --- | --- |
| Routing Style | File-based | Controller/action-based |
| Route Definition | ``@page`` directive | ``MapControllerRoute`` or attributes |
| Best For | Page-centric apps | Complex, multi-controller apps |

🧪 How to Run the Demo
Set RazorPagesRoutingDemo as the startup project

Run the application

Test routes such as:
/Products
/Products/Details/3
/Blog/Post/2024/04/intro-to-routing

✅ Summary
This module provides a clean, practical introduction to Razor Pages routing, preparing learners to understand how routing differs between Minimal APIs, MVC, and Razor Pages.
















