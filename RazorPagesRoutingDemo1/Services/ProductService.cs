using RazorPagesRoutingDemo1.Models;

namespace RazorPagesRoutingDemo1.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new()
        {
            new Product {
                Id = 1,
                Name = "Smartphone X",
                Slug = "smartphone-x",
                Category = "Phones",
                Price = 699,
                Stock = 15,
                ImageUrl = "/Images/cellphone.png",
                Description = "A modern smartphone with a bright display and long‑lasting battery."
            },
            new Product {
                Id = 2,
                Name = "Tablet Pro",
                Slug = "tablet-pro",
                Category = "Phones",
                Price = 499,
                Stock = 10,
                ImageUrl = "/Images/tablet_1093458.png",
                Description = "A lightweight tablet ideal for reading, browsing, and productivity."
            },
            new Product {
                Id = 3,
                Name = "Laptop Air",
                Slug = "laptop-air",
                Category = "Computers",
                Price = 1099,
                Stock = 8,
                ImageUrl = "/Images/laptop.png",
                Description = "A sleek and powerful laptop designed for everyday computing."
            },
            new Product {
                Id = 4,
                Name = "Laptop Studio",
                Slug = "laptop-studio",
                Category = "Computers",
                Price = 1499,
                Stock = 5,
                ImageUrl = "/Images/laptop-512512.png",
                Description = "A high‑performance laptop with advanced graphics for creators."
            },
            new Product {
                Id = 5,
                Name = "Wireless Earbuds",
                Slug = "wireless-earbuds",
                Category = "Audio",
                Price = 129,
                Stock = 25,
                ImageUrl = "/Images/earbuds_9563418.png",
                Description = "Compact earbuds with rich sound and all‑day comfort."
            },
            new Product {
                Id = 6,
                Name = "Studio Headphones",
                Slug = "studio-headphones",
                Category = "Audio",
                Price = 199,
                Stock = 12,
                ImageUrl = "/Images/headphones.png",
                Description = "Over‑ear headphones with deep bass and noise isolation."
            },
            new Product {
                Id = 7,
                Name = "Smart Speaker Mini",
                Slug = "smart-speaker-mini",
                Category = "Audio",
                Price = 89,
                Stock = 30,
                ImageUrl = "/Images/voice-assistant_6781904.png",
                Description = "A compact smart speaker with voice assistant support."
            },
            new Product {
                Id = 8,
                Name = "Wireless Mouse",
                Slug = "wireless-mouse",
                Category = "Accessories",
                Price = 39,
                Stock = 40,
                ImageUrl = "/Images/mouse_9443862.png",
                Description = "A smooth and responsive wireless mouse for everyday use."
            },
            new Product {
                Id = 9,
                Name = "Mechanical Keyboard",
                Slug = "mechanical-keyboard",
                Category = "Accessories",
                Price = 89,
                Stock = 18,
                ImageUrl = "/Images/keyboard_689351.png",
                Description = "A durable mechanical keyboard with tactile feedback."
            },
            new Product {
                Id = 10,
                Name = "Smartwatch Active",
                Slug = "smartwatch-active",
                Category = "Wearables",
                Price = 249,
                Stock = 20,
                ImageUrl = "/Images/smartwatch_18418574.png",
                Description = "A stylish smartwatch with fitness tracking and notifications."
            }
        };

        public Task<List<Product>> GetAllProductsAsync()
        {
            return Task.FromResult(_products);
        }

        public Task<Product?> GetProductByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(product);
        }
    }
}
