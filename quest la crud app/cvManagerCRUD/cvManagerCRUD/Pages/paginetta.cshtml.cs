using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using sediApiCrud.model;

namespace cvManagerCRUD.Pages
{
    public class paginettaModel : PageModel
    {
        [BindProperty]
        public int id { get; set; }
        public List<Sede> ListOfSedy { get; set; }


        private static readonly HttpClient client = new()
        {
            BaseAddress = new Uri("https://localhost:7190")
        };

        private readonly string uri = "sediApiCrud/sede";

        public paginettaModel()
        {
            ListOfSedy = new List<Sede>();
        }
        // This method will be called when the page is first loaded to display the data.

      public async Task<IActionResult> OnGet()
        {
           // List<Sede>? sediDaApi = await client.GetFromJsonAsync<List<Sede>>(uri);
         //   ListOfSedy = sediDaApi;
            return Page();
        }



        // This method will handle the creation of a new record.
        public async Task<IActionResult> OnPostCreate(Sede newSede)
        {
            // Implement the logic to add the newSede to the database.
            // For example:
            // await AddToDatabase(newSede);
          
            // Then redirect back to the page after adding the record.
            return RedirectToPage();
        }

        // This method will handle updating an existing record.
        public async Task<IActionResult> OnPostEdit(Sede updatedSede)
        {
            // Implement the logic to update the existing record in the database.
            // For example:
            // await UpdateInDatabase(updatedSede);
            // Then redirect back to the page after updating the record.
            return RedirectToPage();
        }

        // This method will handle deleting a record.
        public async Task<IActionResult> OnPostDelete(int id)
        {
            // Implement the logic to delete the record with the given id from the database.
            // For example:
            // await DeleteFromDatabase(id);
            // Then redirect back to the page after deleting the record.
            return RedirectToPage();
        }

       
    }
}
