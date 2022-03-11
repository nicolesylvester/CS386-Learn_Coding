using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace codeHub.Pages
{
    public class WCourseModel : PageModel
    {
        private readonly ILogger<WWCourseModel> _logger;

        public WCourseModel(ILogger<WCourseModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}