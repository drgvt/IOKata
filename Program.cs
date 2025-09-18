global using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your file's path (for example, C:\\temp\\data.txt):");
        string filePath = Console.ReadLine();

        Console.WriteLine($"Working on: {Path.GetFullPath(filePath)}");

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Not found... No problem, we'll create it!");
            File.WriteAllText(filePath, "The file was not found and was just created!");
        }

        Console.WriteLine("\n=== Content ===");
        string content = File.ReadAllText(filePath);
        Console.WriteLine(string.IsNullOrEmpty(content) ? "(empty!)" : content);

        Console.WriteLine("\n=== Let's write something! ===");
        File.WriteAllText(filePath, "Have a nice day!");

        Console.WriteLine("\n=== New info ===");
        content = File.ReadAllText(filePath);
        Console.WriteLine(content);
    }
}
