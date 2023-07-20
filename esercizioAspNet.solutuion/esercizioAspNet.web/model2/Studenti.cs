// Import the System.Text.Json namespace for JSON-related operations
using System.Text.Json;

// Import the Microsoft.AspNetCore.Mvc.RazorPages namespace for Razor Pages related functionality
using Microsoft.AspNetCore.Mvc.RazorPages;

// Declare the namespace for the current file
namespace esercizioAspNet.web.model2
{
    // Declare a public class called Studenti
    // This class represents a collection of Student objects
    public class Studenti
    {
        // Define a public property for the class
        // The property is of type List<Student> and is named ListaStudenti
        // It represents a list of Student objects
        public List<Student> ListaStudenti { get; set; }

        // Define a default constructor for the class
        // The constructor is called when an object of the Studenti class is created
        public Studenti()
        {
            // Initialize the ListaStudenti property with a new instance of List<Student>
            ListaStudenti = new List<Student>();
        }
    }
}
