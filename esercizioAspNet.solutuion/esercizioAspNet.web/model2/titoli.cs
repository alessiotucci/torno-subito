using System.Text.Json;                       // Import the System.Text.Json namespace to use JSON serialization and deserialization
using esercizioAspNet.web.model2;              // Import the namespace that contains the "TitoliDiStudio" class
using Microsoft.AspNetCore.Mvc.RazorPages;      // Import the namespace that provides the base class for Razor Pages

namespace esercizioAspNet.web.model2
{
    // Declare a public class named "Titoli"
    // A class is a blueprint or template for creating objects
    // We use the public access modifier to make the class accessible from other parts of the codebase
    public class Titoli
    {
        // Declare a public property named "titoliDiStudio" of type List<TitoliDiStudio>
        // A property is a member of a class that provides a way to access or modify its values
        // We use the public access modifier to make the property accessible from other parts of the codebase
        // The property name follows the PascalCase naming convention, starting with an uppercase letter
        public List<TitoliDiStudio> titoliDiStudio { get; set; }

        // Declare a public constructor for the "Titoli" class
        // A constructor is a special method that is called when an object of the class is created
        // In this constructor, we initialize the "titoliDiStudio" property with a new instance of List<TitoliDiStudio>
        public Titoli()
        {
            titoliDiStudio = new List<TitoliDiStudio>();          // Initialize the "titoliDiStudio" property with a new instance of List<TitoliDiStudio>
        }
    }
}
