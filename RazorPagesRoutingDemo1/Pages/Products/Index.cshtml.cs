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

        // Pagination
        [BindProperty(SupportsGet = true)]
        public int Page { get; set; } = 1;

        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 10;

        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);

        // Search term from query string
        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }

        // Category filter from query string
        [BindProperty(SupportsGet = true)]
        public string? Category { get; set; }

        // Sorting column (Name, Price, Category)
        [BindProperty(SupportsGet = true)]
        public string? SortBy { get; set; }

        // Sorting direction (asc, desc)
        [BindProperty(SupportsGet = true)]
        public string? SortDirection { get; set; } = "asc";

        // Data for the UI
        public List<Product> Products { get; set; } = new();
        public IEnumerable<string> Categories { get; set; } = new List<string>();

        public async Task OnGetAsync()
        {
            // Load categories for dropdown
            Categories = await _productService.GetCategoriesAsync();

            // Load filtered + sorted + paginated products
            var result = await _productService.GetProductsAsync(
                search: SearchTerm,
                category: Category,
                sortBy: SortBy,
                sortDirection: SortDirection,
                page: Page,
                pageSize: PageSize
            );

            Products = result.Items.ToList();
            TotalCount = result.TotalCount;
        }
    }
}
