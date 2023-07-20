// Import the namespace for the Sede class
using esercizioAspNet.web.model2;

// Import the necessary namespaces for MVC-related functionality
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Import the System.Text.Json namespace for JSON-related operations
using System.Text.Json;

// Declare the namespace for the current file
// The 'namespace' is a way to organize and group related classes, interfaces, and other types in a hierarchical manner.
// It helps to avoid naming conflicts and provides a logical structure to the codebase.
namespace esercizioAspNet.web.Pages
{
    // Declare a public class called titoliModel that inherits from PageModel
    // This class represents the code-behind for the titoli.cshtml page
    public class titoliModel : PageModel
    {
        // Define a public property for the class
        // The property is of type List<TitoliDiStudio> and is named Lista
        // It represents a list of TitoliDiStudio objects
        public List<TitoliDiStudio> Lista { get; set; }

        // Define a default constructor for the class
        // The constructor is called when an object of the titoliModel class is created
        public titoliModel()
        {
            // Specify the path to the JSON file containing the data
            string nomeDelFile = "./wwwroot/json/titoloDiStudio.json";

            // Read the JSON file and deserialize its contents into an instance of the Titoli class
            // Assign the list of TitoliDiStudio objects from the deserialized Titoli object to the Lista property
            using (FileStream oggFilSysm = System.IO.File.OpenRead(nomeDelFile))
            {
                var thisy = JsonSerializer.Deserialize<Titoli>(oggFilSysm);
                Lista = thisy.titoliDiStudio;
            }
        }

        // Define a method called OnGet
        // This method is executed when the GET HTTP request is made to the page
        public void OnGet()
        {
            // The OnGet method is currently empty, meaning no additional actions are taken on the GET request
        }
    }
}
