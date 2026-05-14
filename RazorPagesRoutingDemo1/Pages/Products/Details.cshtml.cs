using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesRoutingDemo.Pages.Products
{
    public class DetailsModel : PageModel
    {
        [FromRoute]
        public int Id { get; set; }

        public void OnGet()
        {
        }
    }
}
