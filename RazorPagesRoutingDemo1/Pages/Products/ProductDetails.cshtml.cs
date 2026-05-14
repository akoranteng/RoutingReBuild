using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRoutingDemo1.Services;
using RazorPagesRoutingDemo1.Models;
using System.Threading.Tasks;

namespace RazorPagesRoutingDemo1.Pages.Products
{
    public class ProductDetailsModel : PageModel
    {
        private readonly IProductService _service;

        public Product? Product { get; set; }

        public ProductDetailsModel(IProductService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id, string? slug)
        {
            Product = await _service.GetProductByIdAsync(id);

            if (Product == null)
                return RedirectToPage("ProductNotFound");

            return Page();
        }
    }
}
