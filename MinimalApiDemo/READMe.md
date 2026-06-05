# MinimalApiDemo  
This module introduces the fundamentals of **ASP.NET Core Minimal API routing**.  
It serves as Module 01 in the Routing Workshop and establishes the foundation for the MVC and Razor Pages routing modules that follow.

Minimal APIs provide a lightweight, fast, and expressive way to define HTTP endpoints without controllers, attributes, or the full MVC pipeline.

---

## 📌 Project Goals
By the end of this module, learners will understand:

- How Minimal APIs map routes using `MapGet`, `MapPost`, `MapPut`, and `MapDelete`
- How route templates work in Minimal APIs
- How to define route parameters
- How to apply route constraints
- How to return JSON responses
- How to organize endpoints cleanly
- How endpoint routing differs from MVC and Razor Pages

This module intentionally keeps the code small and focused on routing concepts only.

---

## 📁 Folder Structure


/MinimalApiDemo
│
├── Program.cs
├── Models
│   └── Product.cs
├── Services
│   └── ProductService.cs
└── README.md   (this file)

Minimal APIs typically do not use controllers or Razor Pages — everything is wired through `Program.cs`.

---

## 🧭 Routing Concepts Demonstrated

### **1. Basic Endpoint Mapping**
Examples:

```csharp
app.MapGet("/products", () => service.GetAll());
app.MapGet("/products/{id}", (int id) => service.GetById(id));

Minimal APIs use endpoint routing, not controller/action routing

2. Route Parameters
. Route Parameters
Example:

csharp
app.MapGet("/products/{id:int}", (int id) => ...);

app.MapGet("/products/{id:int}", (int id) => ...);

3. Route Constraints
Examples:

Code
/products/{id:int}
/products/{slug:alpha}
/products/{price:decimal}

4. JSON Responses
Minimal APIs return JSON by default:

csharp
return Results.Json(product);

5. CRUD Endpoints
Examples:

csharp
app.MapPost("/products", (Product p) => service.Add(p));
app.MapPut("/products/{id}", (int id, Product p) => service.Update(id, p));
app.MapDelete("/products/{id}", (int id) => service.Delete(id));

▶️ Running the Demo
From the solution root:

Code
dotnet build
dotnet run --project MinimalApiDemo
Then open (use your environment’s port):
https://localhost:5001/products


## 📊 Routing Comparison: Minimal API vs MVC vs Razor Pages

| Feature / Concept            | Minimal APIs (Module 01)                           | MVC Routing (Module 02)                                      | Razor Pages Routing (Module 03)                               |
|------------------------------|----------------------------------------------------|---------------------------------------------------------------|---------------------------------------------------------------|
| **Routing Style**            | Explicit endpoint mapping (`MapGet`, etc.)         | Attribute routing + conventional routing                      | Folder‑based routing (file path = route)                      |
| **Entry Point**              | `Program.cs`                                       | Controllers + Actions                                         | `.cshtml` pages + PageModel                                   |
| **URL → Code Mapping**       | Directly in code via lambdas                       | Controller/Action discovery                                   | File/folder structure                                         |
| **Route Templates**          | Inline strings in `MapGet`/`MapPost`               | `[Route]`, `[HttpGet]`, `[HttpPost]` attributes               | Implicit from folder path, optional `@page "{id}"`            |
| **Route Parameters**         | `{id}`, `{id:int}`, `{slug:alpha}`                 | Strong attribute support with constraints                     | Declared in `@page` directive                                 |
| **Constraints**              | Supported via template (`{id:int}`)                | Richest constraint system                                     | Supported but less commonly used                              |
| **Best For**                 | Lightweight APIs, microservices, small endpoints   | Full MVC apps, structured controllers, REST APIs              | Content‑driven apps, admin portals, page‑based workflows      |
| **Return Types**             | Objects auto‑serialized to JSON                    | `IActionResult`, strongly typed responses                     | Page rendering + handlers                                     |
| **Routing Complexity**       | Simple → Medium                                    | Medium → Advanced                                             | Simple → Medium                                               |
| **Learning Focus**           | Endpoint routing fundamentals                      | Attribute routing, controller discovery                       | Folder routing, page handlers                                 |
