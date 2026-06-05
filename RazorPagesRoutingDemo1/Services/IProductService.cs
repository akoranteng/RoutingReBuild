using RazorPagesRoutingDemo1.Models;

namespace RazorPagesRoutingDemo1.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync(
            string category,
            string searchTerm,
            string sortBy,
            string sortDirection);

        Task<List<Product>> GetAllProductsAsync();

        Task<Product?> GetProductByIdAsync(int id);
    }
}
