using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesRoutingDemo.Pages.Products
{
    public class MultipleRoutesModel : PageModel
    {
        [FromRoute]
        public int Id { get; set; }

        [FromRoute]
        public string Slug { get; set; }

        public void OnGet()
        {
            // In a real application, you might fetch product details here.
            // For routing demos, simply displaying the bound values is perfect.
        }
    }
}
