using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class computerLitModel : PageModel
    {
        private readonly ILogger<computerLitModel> _logger;

        public computerLitModel(ILogger<computerLitModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}