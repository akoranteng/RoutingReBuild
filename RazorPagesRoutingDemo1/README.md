📦 Products Module Rebuild
Module 04 — Razor Pages Product Catalog with Filtering, Categories & Images
This module rebuilds the Products feature of the Razor Pages application from the ground up.
It replaces the earlier placeholder demo with a clean, maintainable, service‑driven product catalog that supports:

Product listing

Category filtering

Text search

Image display

Slug‑based routing (foundation for future detail pages)

A clean separation of concerns using IProductService

This module serves as a foundation for future enhancements such as product details, pagination, sorting, and cart functionality.
Learning Objectives
By completing this module, you will learn how to:

Build a service layer in Razor Pages (IProductService + ProductService)

Provide data to Razor Pages using PageModel properties

Implement search and category filtering

Render product images from wwwroot

Use model binding with SupportsGet = true

Organize Razor Pages into feature‑based folders (/Pages/Products)

Prepare for slug‑based routing and detail pages

RazorPagesRoutingDemo1/
│
├── Models/
│   └── Product.cs
│
├── Services/
│   ├── IProductService.cs
│   └── ProductService.cs
│
├── Pages/
│   └── Products/
│       ├── Index.cshtml
│       └── Index.cshtml.cs
│
└── wwwroot/
    └── Images/
        ├── cellphone.png
        ├── tablet_1093458.png
        ├── laptop.png
        ├── laptop-512512.png
        ├── earbuds_9563418.png
        ├── headphones.png
        ├── voice-assistant_6781904.png
        ├── mouse_9443862.png
        ├── keyboard_689351.png
        └── smartwatch_18418574.png

        

🧩 Key Components
1. Product Model
Defines the structure of a product:

Id

Name

Slug

Category

Price

Stock

ImageUrl

Description


2. ProductService
Provides an in‑memory product catalog and exposes:

csharp
Task<List<Product>> GetAllProductsAsync();
3. Products Page (Index.cshtml.cs)
Handles:

Loading products from the service

Building the category list

Applying search and category filters

Exposing data to the Razor Page

4. Products UI (Index.cshtml)
Implements:

Search bar

Category dropdown

Product list

Image rendering

SearchTerm
Matches product names (case‑insensitive).

Category
Filters by exact category match.

Both filters work together and are preserved in the query string.

All product images are stored in:

Code
wwwroot/Images/

🚀 What’s Next (Recommended Next Module)
Suggested Module 05 topics:

Product Details Page (/Products/{slug})

Slug routing

Bootstrap card layout for products

Sorting (price, name, category)
