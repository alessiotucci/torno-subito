using system_design;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("let create a new vehicle!");

var atac = new Autobus();

Console.WriteLine(atac.GetPostiDisponibili());

atac.Alzati();

Console.WriteLine($"this is {atac.GetPostiDisponibili()}");

Console.ReadLine();



