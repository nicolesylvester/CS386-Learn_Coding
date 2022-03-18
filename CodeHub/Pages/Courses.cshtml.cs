using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class CoursesModel : PageModel
    {
        private readonly ILogger<CoursesModel> _logger;

        public CoursesModel(ILogger<CoursesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}