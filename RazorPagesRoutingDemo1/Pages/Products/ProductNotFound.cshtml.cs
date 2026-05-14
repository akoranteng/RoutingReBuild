using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesRoutingDemo1.Pages.Products
{
    public class ProductNotFoundModel : PageModel
    {
        public int Id { get; set; }

        public void OnGet(int id)
        {
            Id = id;
        }
    }
}
