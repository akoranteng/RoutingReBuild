# RazorPagesRoutingDemo1  
A focused demonstration of **Razor Pages routing**, including page routes, route parameters, slug-based navigation, sorting, searching, and common routing gotchas.

This project is part of the **ASP.NET Core Routing Workshop**, alongside:
- `MinimalApiDemo`
- `MvcRoutingDemo`
- `RazorPagesRoutingDemo1` (this project)

---

## 📌 Project Goals
This module demonstrates how Razor Pages uses:
- **Folder-based routing**
- **PageModel conventions**
- **Route templates**
- **Slug routing**
- **Query-string based sorting & searching**
- **Custom route parameters**
- **Routing gotchas and fixes**

It also includes a fully in-memory `ProductService` used to demonstrate:
- Slug-based product details  
- Category filtering  
- Search  
- Sorting by name, price, and category  

---

## 📁 Folder Structure

/RazorPagesRoutingDemo1
│
├── Pages
│   ├── Index.cshtml
│   ├── Products
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   │   └── Search.cshtml
│   └── Shared
│
├── Services
│   └── ProductService.cs
│
├── Models
│   └── Product.cs
│
└── wwwroot
└── Images (10 demo product images)

Code

---

## 🧭 Routing Concepts Demonstrated

### **1. Folder-Based Routing**
Razor Pages maps URLs based on folder structure:

No controller is required.

---

### **2. Route Templates**
The `@page` directive can include route templates:

```csharp
@page "{slug}"
This enables clean URLs like
/products/wireless-earbuds

3. Sorting & Searching
Sorting is handled via query strings:

Code
/products?sortBy=name
/products?sortBy=price
/products?sortBy=category

Searching:

Code
/products/search?term=tablet
4. Category Filtering
Example:

▶️ Running the Demo
From the solution root:

Code
dotnet build
dotnet run --project RazorPagesRoutingDemo1
Then open:
https://localhost:5001/products

Please note the Port# has to adjusted for the local environment

🧩 Milestone Notes (Branch: 05-products-sorting)
This branch includes:

Full ProductService rebuild

Sorting feature

Search feature

Category filtering

Slug-based product details

Restored product images

Cleaned workspace

Updated .gitignore

Git index cleanup

Successful push to GitHub

Restored product images

Cleaned workspace

Updated .gitignore

Git index cleanup

Successful push to GitHub






