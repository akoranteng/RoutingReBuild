# Module 02: MVC Routing Demo

## Overview
This module demonstrates the fundamentals of **ASP.NET Core MVC routing** using a clean, attribute‑routed Admin module. It builds on the Minimal API concepts from Module 01 and introduces how MVC discovers controllers and maps URLs to actions.

The project is intentionally minimal and focused on routing concepts only.

---

## Learning Objectives
By the end of this module, learners will understand:

- How MVC discovers controllers  
- How attribute routing works  
- How to apply route templates  
- How to use route constraints  
- How to define optional parameters  
- How to design clean, predictable URL structures  
- How to test and debug routing in the browser  

---

## AdminController Endpoints

| HTTP Verb | Route | Description |
|-----------|--------|-------------|
| GET | `/admin` | Admin landing page |
| GET | `/admin/users` | List of users |
| GET | `/admin/users/{id:int}` | User details with integer constraint |
| GET | `/admin/dashboard` | Dashboard endpoint |
| GET | `/admin/reports` | Reports endpoint |
| GET | `/admin/settings` | Settings endpoint |
| GET | `/admin/logs/{date?}` | Logs endpoint with optional date parameter |

---

## Key Routing Concepts Demonstrated

### 1. Controller‑level route prefix
```csharp
[Route("admin")]
public class AdminController : Controller
