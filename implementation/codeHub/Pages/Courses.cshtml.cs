using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace codeHub.Pages
{
    public class CourseModel : PageModel
    {
        private readonly ILogger<CourseModel> _logger;

        public CourseModel(ILogger<CourseModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}