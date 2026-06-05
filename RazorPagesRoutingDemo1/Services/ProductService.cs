using RazorPagesRoutingDemo1.Models;

namespace RazorPagesRoutingDemo1.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Cell Phone",
                Slug = "cell-phone",
                Category = "Electronics",
                Price = 699,
                Stock = 12,
                ImageUrl = "/Images/cellphone.png",
                Description = "A modern smartphone with a high‑resolution display and long‑lasting battery."
            },
            new Product
            {
                Id = 2,
                Name = "Laptop",
                Slug = "laptop",
                Category = "Computers",
                Price = 1299,
                Stock = 5,
                ImageUrl = "/Images/laptop-512512.png",
                Description = "A lightweight laptop designed for productivity and performance."
            },
            new Product
            {
                Id = 3,
                Name = "Headphones",
                Slug = "headphones",
                Category = "Audio",
                Price = 199,
                Stock = 0,
                ImageUrl = "/Images/headphones.png",
                Description = "Noise‑cancelling over‑ear headphones with premium sound quality."
            },
            new Product
            {
                Id = 4,
                Name = "Bluetooth Speaker",
                Slug = "bluetooth-speaker",
                Category = "Audio",
                Price = 149,
                Stock = 18,
                ImageUrl = "/Images/voice-assistant_6781904.png",
                Description = "Portable Bluetooth speaker with deep bass and 12‑hour battery life."
            },
            new Product
            {
                Id = 5,
                Name = "Smartwatch",
                Slug = "smartwatch",
                Category = "Electronics",
                Price = 249,
                Stock = 9,
                ImageUrl = "/Images/smartwatch_18418574.png",
                Description = "A stylish smartwatch with fitness tracking and notifications."
            },
            new Product
            {
                Id = 6,
                Name = "Gaming Mouse",
                Slug = "gaming-mouse",
                Category = "Computers",
                Price = 59,
                Stock = 25,
                ImageUrl = "/Images/mouse_9443862.png",
                Description = "Ergonomic gaming mouse with customizable RGB lighting."
            },
            new Product
            {
                Id = 7,
                Name = "Mechanical Keyboard",
                Slug = "mechanical-keyboard",
                Category = "Computers",
                Price = 129,
                Stock = 14,
                ImageUrl = "/Images/keyboard_689351.png",
                Description = "Mechanical keyboard with tactile switches and backlighting."
            },
            new Product
            {
                Id = 8,
                Name = "4K Monitor",
                Slug = "4k-monitor",
                Category = "Computers",
                Price = 399,
                Stock = 7,
                ImageUrl = "/Images/monitor_2292061.png",
                Description = "Ultra‑HD 4K monitor with vibrant colors and thin bezels."
            },
            new Product
            {
                Id = 9,
                Name = "Wireless Charger",
                Slug = "wireless-charger",
                Category = "Electronics",
                Price = 39,
                Stock = 30,
                ImageUrl = "/Images/elexa-charger-4970584_1920.jpg",
                Description = "Fast wireless charging pad compatible with most smartphones."
            },
            new Product
            {
                Id = 10,
                Name = "Tablet",
                Slug = "tablet",
                Category = "Electronics",
                Price = 499,
                Stock = 6,
                ImageUrl = "/Images/tablet_1093458.png",
                Description = "A lightweight tablet perfect for streaming, reading, and browsing."
            }
        };

        // Filtering + Sorting
        public Task<List<Product>> GetProductsAsync(
            string category,
            string searchTerm,
            string sortBy,
            string sortDirection)
        {
            IEnumerable<Product> products = _products;

            // Filtering
            if (!string.IsNullOrWhiteSpace(category))
            {
                products = products.Where(p =>
                    p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                products = products.Where(p =>
                    p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
            }

            // Sorting
            products = (sortBy, sortDirection.ToLower()) switch
            {
                ("Name", "asc") => products.OrderBy(p => p.Name),
                ("Name", "desc") => products.OrderByDescending(p => p.Name),

                ("Price", "asc") => products.OrderBy(p => p.Price),
                ("Price", "desc") => products.OrderByDescending(p => p.Price),

                ("Quantity", "asc") => products.OrderBy(p => p.Stock),
                ("Quantity", "desc") => products.OrderByDescending(p => p.Stock),

                _ => products.OrderBy(p => p.Name)
            };

            return Task.FromResult(products.ToList());
        }

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
