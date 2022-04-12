using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class WebDevModel : PageModel
    {
        private readonly ILogger<WebDevModel> _logger;

        public WebDevModel(ILogger<WebDevModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}