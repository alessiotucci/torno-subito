using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using sediApiCrud.model;

namespace cvManagerCRUD.Pages
{
    public class paginettaModel : PageModel
    {
       // [BindProperty]
        public List<Sede> sedi;
        
        // those are the methods needed to create the razor pages
        public async Task<IActionResult> OnGet()
        {
            sedi = await GetAll();
        }
        public async Task<IActionResult> GetById()
        {

        }
    }
}
