// Define the namespace
// A namespace is like a container that groups related code together
// It helps organize code and prevents naming conflicts between different parts of a project
namespace esercizioAspNet.web.model2
{
    // Declare a public class called TitoliDiStudio
    // A class is a blueprint or template for creating objects that have properties (data) and methods (functions)
    // In this case, the class represents a "TitoliDiStudio" object, which has properties for ID, voto, and indirizzo
    // The class is marked as public, which means it can be accessed from other parts of the code
    public class TitoliDiStudio
    {
        // Define public properties for the class
        // A property is like a variable associated with an object that can be read from and written to
        // In this case, the class has properties for ID, voto, and indirizzo, which can hold different values
        public int ID { get; set; }
        public string voto { get; set; }
        public string indirizzo { get; set; }

        // Define a default constructor for the class
        // A constructor is a special method that is called when an object is created from a class
        // In this case, the constructor is empty, meaning it doesn't perform any specific initialization tasks
        public TitoliDiStudio()
        {
            // No code inside the constructor
        }
    }
}
