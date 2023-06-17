using System;           // Import the System namespace for basic functionality
using System.IO;        // Import the System.IO namespace for file I/O
using System.Text;      // Import the System.Text namespace for string handling
using System.Math;      // Import the System.Math namespace for mathematical functions

class Program
{
    static void Main()
    {
        // You can now use classes and functions from the imported namespaces

        // Example: Reading a line from the console
        string input = Console.ReadLine();

        // Example: Writing a line to a file
        File.WriteAllText("output.txt", "Hello, World!");

        // Example: Using string manipulation functions

    }
}
