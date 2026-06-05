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

        // Bound properties for filtering + sorting
        [BindProperty(SupportsGet = true)]
        public string? Category { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortBy { get; set; } = "Name";

        [BindProperty(SupportsGet = true)]
        public string SortDirection { get; set; } = "asc";

        public List<Product> Products { get; set; } = new();

        public async Task OnGetAsync()
        {
            Products = await _productService.GetProductsAsync(
                Category ?? "",
                SearchTerm ?? "",
                SortBy,
                SortDirection
            );
        }
    }
}
