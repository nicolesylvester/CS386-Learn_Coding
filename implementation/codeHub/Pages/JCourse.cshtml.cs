using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace codeHub.Pages
{
    public class JCourseModel : PageModel
    {
        private readonly ILogger<JCourseModel> _logger;

        public JCourseModel(ILogger<JCourseModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}