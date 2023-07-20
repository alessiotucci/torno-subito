// Import the necessary namespaces for MVC-related functionality
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Declare the namespace and the class for the page
namespace esercizioAspNet.web.Pages
{
    // The 'IndexModel' class represents the code-behind for the 'Index' page.
    // It inherits from the 'PageModel' class, which provides the basic functionality for Razor Pages.
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        // The constructor is used to inject the logger into the page model.
        // The logger can be used to log information, warnings, and errors.
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // The 'OnGet' method is executed when the page is requested using the HTTP GET method.
        // It handles the logic for handling GET requests to the page.
        public void OnGet()
        {
            // This method can be used to perform any necessary operations or actions when the page is requested.
            // In this case, the method is empty, so no specific actions are performed.
        }
    }
}
