using RazorPagesRoutingDemo1.Models;

namespace RazorPagesRoutingDemo1.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);


    }
}
