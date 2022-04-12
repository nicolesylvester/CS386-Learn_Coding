using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class PythonModel : PageModel
    {
        private readonly ILogger<PythonModel> _logger;

        public PythonModel(ILogger<PythonModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}