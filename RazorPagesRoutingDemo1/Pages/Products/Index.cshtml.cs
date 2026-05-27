using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRoutingDemo1.Models;
using RazorPagesRoutingDemo1.Services;

namespace RazorPagesRoutingDemo1.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products { get; set; } = new();
        public List<string> Categories { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Category { get; set; }

        public async Task OnGet()
        {
            // Load all products
            Products = await _productService.GetAllProductsAsync();

            // Build category list
            Categories = Products
                .Select(p => p.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                Products = Products
                    .Where(p => p.Name.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Apply category filter
            if (!string.IsNullOrWhiteSpace(Category))
            {
                Products = Products
                    .Where(p => p.Category == Category)
                    .ToList();
            }
        }
    }
}
