using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace codeHub.Pages
{
    public class PyCourseModel : PageModel
    {
        private readonly ILogger<PyCourseModel> _logger;

        public PyCourseModel(ILogger<PyCourseModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}