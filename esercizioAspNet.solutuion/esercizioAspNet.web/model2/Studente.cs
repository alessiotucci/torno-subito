// Declare the namespace for the current file
namespace esercizioAspNet.web.model2
{
    // Declare a public class called Student
    // This class represents a student with various properties
    public class Student
    {
        // Define public properties for the class
        // The properties represent the attributes of a student

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }
        public List<int> Grades { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public string Attitudine { get; set; }
        public string DescrizionePersonale { get; set; }

        // Create a parameterless constructor for the class
        // This constructor is required for deserialization from JSON

        public Student()
        {

        }
    }
}
