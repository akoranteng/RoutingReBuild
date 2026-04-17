📘 Module 01 — Minimal API Routing Basics
What This Module Demonstrates
- How ASP.NET Core maps URLs to Minimal API endpoints
- Basic HTTP verbs: MapGet, MapPost, MapPut, MapDelete
- Route parameters (e.g., /products/{id})
- Query strings (e.g., /search?term=abc)
- Returning JSON automatically
- Using typed results for modern .NET 8/10 patterns
- Running and testing endpoints in Swagger UI
🧩 Endpoints in This Module
GET /hello
Returns a simple JSON greeting.
GET /products/{id}
Demonstrates route parameters and typed results.
GET /search
Demonstrates query string handling.
POST /products
Demonstrates receiving JSON input.
PUT /products/{id}
Demonstrates updating a resource.
DELETE /products/{id}
Demonstrates deleting a resource.

 How to Run This Module
dotnet run


Then open Swagger UI:
https://localhost:5001/swagger

⭐ Add  Program.cs structure for Module 01




