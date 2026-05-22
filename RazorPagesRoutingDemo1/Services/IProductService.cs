using RazorPagesRoutingDemo1.Models;

namespace RazorPagesRoutingDemo1.Services
{

    public interface IProductService
    {
        // NEW pagination method
        Task<(IEnumerable<Product> Items, int TotalCount)> GetProductsAsync(
            string? search,
            string? category,
            string? sortBy,
            string? sortDirection,
            int page,
            int pageSize);

        // Existing methods your PageModel still calls
        Task<IEnumerable<string>> GetCategoriesAsync();
        Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm);

        // CRUD methods
        Task<Product?> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }


}



