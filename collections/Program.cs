using System;
using System.Collections.Generic; // Needed for List

class Program
{
    static void Main()
    {
        // Create a list of strings
        List<string> names = new List<string>();

        // Add elements
        names.Add("Ram");
        names.Add("Sita");
        names.Add("Hari");

        // Display all names
        Console.WriteLine("List of names:");
        foreach (string n in names)
        {
            Console.WriteLine(n);
        }

        // Remove an item
        names.Remove("Sita");

        Console.WriteLine("\nAfter removing Sita:");
        foreach (string n in names)
        {
            Console.WriteLine(n);
        }
    }
}
