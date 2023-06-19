// Import the System.Text.Json namespace
// The System.Text.Json namespace provides classes and methods for working with JSON data
using System.Text.Json;

// Import the esercizioAspNet.web.model2 namespace
// This imports the namespace where the TitoliDiStudio class is defined
using esercizioAspNet.web.model2;

// Import the Microsoft.AspNetCore.Mvc.RazorPages namespace
// This imports the namespace required for working with Razor Pages in ASP.NET Core
using Microsoft.AspNetCore.Mvc.RazorPages;

// Declare the namespace for the current file
namespace esercizioAspNet.web.model2
{
    // Declare a public class called Titoli
    // This class represents a collection of TitoliDiStudio objects
    public class Titoli
    {
        // Define a public property for the class
        // The property is of type List<TitoliDiStudio> and is named titoliDiStudio
        // It represents a list that can hold multiple TitoliDiStudio objects
        public List<TitoliDiStudio> titoliDiStudio { get; set; }

        // Define a default constructor for the class
        // The constructor is called when an object of the Titoli class is created
        public Titoli()
        {
            // Initialize the titoliDiStudio property with a new instance of List<TitoliDiStudio>
            // This ensures that the property is not null and ready to hold TitoliDiStudio objects
            titoliDiStudio = new List<TitoliDiStudio>();
        }
    }
}
