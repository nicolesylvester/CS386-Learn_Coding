using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class QAModel : PageModel
    {
        private readonly ILogger<QAModel> _logger;

        public QAModel(ILogger<QAModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}