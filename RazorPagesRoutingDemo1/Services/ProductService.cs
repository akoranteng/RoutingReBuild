using Microsoft.EntityFrameworkCore;
using RazorPagesRoutingDemo1.Models;
using RazorPagesRoutingDemo1.Services;
using RazorPagesRoutingDemo1.Data;

public class ProductService : IProductService
{
    private readonly ApplicationDbContext _context;

    public ProductService(ApplicationDbContext context)
    {
        _context = context;
    }

    // ---------------------------------------------------------
    // PAGINATION + FILTERING + SORTING
    // ---------------------------------------------------------
    public async Task<(IEnumerable<Product> Items, int TotalCount)> GetProductsAsync(
        string? search,
        string? category,
        string? sortBy,
        string? sortDirection,
        int page,
        int pageSize)
    {
        var query = _context.Products.AsQueryable();

        // Filtering
        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(p =>
                p.Name.Contains(search) ||
                p.Description.Contains(search));
        }

        if (!string.IsNullOrWhiteSpace(category))
        {
            query = query.Where(p => p.Category == category);
        }

        // Sorting
        query = (sortBy, sortDirection) switch
        {
            ("name", "asc") => query.OrderBy(p => p.Name),
            ("name", "desc") => query.OrderByDescending(p => p.Name),
            ("price", "asc") => query.OrderBy(p => p.Price),
            ("price", "desc") => query.OrderByDescending(p => p.Price),
            _ => query.OrderBy(p => p.Id)
        };

        // Total count BEFORE pagination
        var totalCount = await query.CountAsync();

        // Pagination
        var items = await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (items, totalCount);
    }

    // ---------------------------------------------------------
    // CATEGORIES
    // ---------------------------------------------------------
    public async Task<IEnumerable<string>> GetCategoriesAsync()
    {
        return await _context.Products
            .Select(p => p.Category)
            .Distinct()
            .OrderBy(c => c)
            .ToListAsync();
    }

    // ---------------------------------------------------------
    // SEARCH
    // ---------------------------------------------------------
    public async Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm)
    {
        return await _context.Products
            .Where(p =>
                p.Name.Contains(searchTerm) ||
                p.Description.Contains(searchTerm))
            .ToListAsync();
    }

    // ---------------------------------------------------------
    // CRUD
    // ---------------------------------------------------------
    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task AddProductAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
