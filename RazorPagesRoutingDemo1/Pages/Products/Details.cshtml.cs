using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRoutingDemo1.Models;
using RazorPagesRoutingDemo1.Services;

namespace RazorPagesRoutingDemo1.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly IProductService _productService;

        public DetailsModel(IProductService productService)
        {
            _productService = productService;
        }

        public Product? Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Product = await _productService.GetProductByIdAsync(id);

            if (Product == null)
                return NotFound();

            return Page();
        }
    }
}
