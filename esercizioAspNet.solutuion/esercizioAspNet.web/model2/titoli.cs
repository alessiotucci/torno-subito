<<<<<<< HEAD
﻿using System.Text.Json;                       // Import the System.Text.Json namespace to use JSON serialization and deserialization
using esercizioAspNet.web.model2;              // Import the namespace that contains the "TitoliDiStudio" class
using Microsoft.AspNetCore.Mvc.RazorPages;      // Import the namespace that provides the base class for Razor Pages
=======
﻿// Import the System.Text.Json namespace
// The System.Text.Json namespace provides classes and methods for working with JSON data
using System.Text.Json;

// Import the esercizioAspNet.web.model2 namespace
// This imports the namespace where the TitoliDiStudio class is defined
using esercizioAspNet.web.model2;

// Import the Microsoft.AspNetCore.Mvc.RazorPages namespace
// This imports the namespace required for working with Razor Pages in ASP.NET Core
using Microsoft.AspNetCore.Mvc.RazorPages;
>>>>>>> 2b18cc18579e6dfac20cce9ee860a21c5bc290c2

// Declare the namespace for the current file
namespace esercizioAspNet.web.model2
{
<<<<<<< HEAD
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
=======
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
>>>>>>> 2b18cc18579e6dfac20cce9ee860a21c5bc290c2
        }
    }
}
