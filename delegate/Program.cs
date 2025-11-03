using System;

// Step 1: Declare a delegate
delegate void GreetingDelegate(string name);

class Program
{
    // Step 2: Create a method matching delegate’s pattern
    static void SayHello(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void Main()
    {
        // Step 3: Create delegate object and point to method
        GreetingDelegate greet = SayHello;

        // Step 4: Call the delegate (which calls the method)
        greet("Ram");
    }
}
