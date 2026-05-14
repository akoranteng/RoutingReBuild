using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRoutingDemo1.Services;
using RazorPagesRoutingDemo1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPagesRoutingDemo1.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _service;

        public List<Product> Products { get; set; } = new();

        public IndexModel(IProductService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            Products = await _service.GetAllProductsAsync();
        }
    }
}
