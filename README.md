ASP.NET Core Routing 101 — Multi‑Project Demo Suite
This solution contains three independent ASP.NET Core 10 projects demonstrating routing fundamentals across the three major hosting models: Minimal APIs, MVC Controllers, and Razor Pages.
Each project is intentionally small, focused, and curriculum‑ready for teaching, demos, and modular learning.

📁 Included Projects
1. MinimalApiDemo
Demonstrates:

Basic route mapping with MapGet, MapPost, MapPut, MapDelete

Route parameters and constraints

Grouped routes

Minimal API conventions

2. MvcRoutingDemo
1. Demonstrates:

Controller‑based routing

Attribute routing

Conventional routing patterns

Route tokens and defaults

Demonstrates:

Controller‑based routing

Attribute routing

Conventional routing patterns

Route tokens and defaults
🧭 Solution Purpose
This solution is designed as a teaching asset for understanding routing across the ASP.NET Core platform. Each project is isolated so learners can focus on one routing model at a time while still seeing how the models relate.

🚀 How to Run
From the solution root:

Code
cd MvcRoutingDemo
dotnet run

Code
cd RazorPagesRoutingDemo
dotnet run

Each project runs independently on its own Kestrel port.
📚 What This Project Demonstrates
Differences between Minimal API, MVC, and Razor Pages routing

How ASP.NET Core resolves endpoints

How route templates are parsed

How route precedence works

How to structure routing for clarity and maintainability

🧩 Folder Structure
AspNetCoreRoutingRebuild/
│
├── MinimalApiDemo/
├── MvcRoutingDemo/
├── RazorPagesRoutingDemo/
│
└── AspNetCoreRoutingRebuild.sln



