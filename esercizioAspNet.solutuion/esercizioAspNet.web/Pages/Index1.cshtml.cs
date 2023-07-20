// Import the necessary namespaces
using esercizioAspNet.web.model2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Text.Json;

namespace esercizioAspNet.web.Pages
{
    public class studentiModel : PageModel
    {
        public List<Student> Studenti { get; set; }
        public List<Student> StudentResults { get; set; } // Define the StudentResults property

        public studentiModel()
        {
            // Specify the path to the JSON file containing the studenti data
            string filePath = "./wwwroot/json/studenti.json";

            // Read the JSON file and deserialize its contents into a list of Studente objects
            using (FileStream fileStream = System.IO.File.OpenRead(filePath))
            {
                var jsonData = JsonSerializer.Deserialize<Studenti>(fileStream);
                Studenti = jsonData.ListaStudenti;
            }
        }
        public IActionResult OnPost(string searchQuery)
        {
            // Log the search query using System.Diagnostics.Debug.WriteLine
            Debug.WriteLine($"Search query: {searchQuery}");

            // Perform the search operation on the "Studenti" list
            List<Student> searchResults = Studenti.Where(s => s.Nome.Contains(searchQuery)).ToList();

            // Assign the search results to a property in the model
            // This property will be used to display the filtered results in the Razor page
            StudentResults = searchResults;

            // Return the current page, which will display the filtered results
            return Page();
        }

        //  public void OnGet()
        //{
        // The OnGet method is currently empty, meaning no additional actions are taken on the GET request
        //}
    }
}
