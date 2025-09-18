
using System;

class StringExample
{
    static void Main()
    {
        string greet = "Hello Everyone";

        //string Methods
        Console.WriteLine(greet);
        Console.WriteLine("Length " + greet.Length);
        Console.WriteLine("Uppercase " + greet.ToUpper());
        Console.WriteLine("Lowercase " + greet.ToLower());
        Console.WriteLine("first Element " + greet[0]);
        Console.WriteLine("substring " + greet.Substring(0, 5));
        Console.WriteLine("replace Everyone to World: " + greet.Replace("Everyone", "World!"));
    }
}