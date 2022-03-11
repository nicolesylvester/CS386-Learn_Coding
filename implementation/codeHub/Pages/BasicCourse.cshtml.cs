using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace codeHub.Pages
{
    public class BaseBaseCourseModel : PageModel
    {
        private readonly ILogger<BaseCourseModel> _logger;

        public BaseCourseModel(ILogger<BaseCourseModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}