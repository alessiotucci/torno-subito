    // Import the System.Text.Json namespace for JSON-related operations
    using System.Text.Json;

    // Import the Microsoft.AspNetCore.Mvc.RazorPages namespace for Razor Pages related functionality
    using Microsoft.AspNetCore.Mvc.RazorPages;

namespace not_working.model2
{
        // Declare a public class called Sedi
        // This class represents a collection of Sede objects
        public class Sedi
        {
            // Define a public property for the class
            // The property is of type List<Sede> and is named ListaSedi
            // It represents a list of Sede objects
            public List<Sede> ListaSedi { get; set; }

            // Define a default constructor for the class
            // The constructor is called when an object of the Sedi class is created
            public Sedi()
            {
                // Initialize the ListaSedi property with a new instance of List<Sede>
                ListaSedi = new List<Sede>();
            }
        }
}