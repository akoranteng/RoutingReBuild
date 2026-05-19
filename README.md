ASP.NET Core Routing ReBuild — Razor Pages Product Catalog Demo

# ASP.NET Core Routing ReBuild  
### Razor Pages • Minimal APIs • MVC • Product Catalog Demo

The goal is to create a clean, modern, educational reference for ASP.NET Core routing, while also building a functional product catalog UI that demonstrates real‑world routing, filtering, and sorting behavior.

## 🚀 Features Implemented (Razor Pages Module)

### ✔ Product Catalog with Full Filtering Pipeline
The Razor Pages demo now includes a complete, production‑style filtering system:

- **Search** (by product name)
- **Category Filter**
- **Sort By** (Name, Price, Category)
- **Sort Direction** (Ascending / Descending)
- **All filters work together** using GET query parameters

Example URL:

/Products?SearchTerm=tablet&Category=Electronics&SortBy=Price&SortDirection=asc

### ✔ Clean, Persistent UI State
All dropdowns and inputs retain their values after filtering, thanks to:

```razor
selected="@(Model.SortBy == "Price")"
Added realistic product images (tablet, speaker, etc.) stored under:
Product Images
wwwroot/images/products

Stable Routing Structure
The Razor Pages module demonstrates:

Page routing

Handler methods

Query parameter binding

Clean URL patterns

Separation of UI and PageModel logic

RoutingReBuild/
│
├── MinimalApiRoutingDemo/
├── MvcRoutingDemo/
└── RazorPagesRoutingDemo/
    ├── Pages/
    │   └── Products/
    │       ├── Index.cshtml
    │       ├── Index.cshtml.cs
    │       ├── Details.cshtml
    │       └── Details.cshtml.cs
    ├── Services/
    └── wwwroot/images/products/

🧠 Learning Goals
This project is designed to reinforce:

ASP.NET Core routing fundamentals

Razor Pages handler methods

Query string binding

UI state persistence

Clean separation of concerns

Building real‑world filtering/sorting pipelines

Git workflow best practices

