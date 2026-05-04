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
                ImageUrl = "/images/cellphone.png",
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
                ImageUrl = "/images/laptop.png",
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
                ImageUrl = "/images/headphones.png",
                Description = "Noise‑cancelling over‑ear headphones with premium sound quality."
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
