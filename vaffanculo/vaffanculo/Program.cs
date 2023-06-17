using System;           // Import the System namespace for basic functionality
using System.IO;        // Import the System.IO namespace for file I/O
using System.Text;      // Import the System.Text namespace for string handling

class Program
{
    static void Main()
    {
        // You can now use classes and functions from the imported namespaces
        int count = 0;
        string prova = "ciao come stai";
        while (count < 5)
        {
            Console.WriteLine("questo e il carattere:" + prova[count]);
            count++;
        }

    }
}

