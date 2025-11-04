using System;

class Program
{
    static void Main(string[] args)
    {
        // Normal method example
        Console.WriteLine("Square using normal method: " + Square(5));

        // Lambda expression equivalent
        Func<int, int> square = x => x * x;
        Console.WriteLine("Square using lambda expression: " + square(5));
    }

    // Normal method
    static int Square(int x)
    {
        return x * x;
    }
}
/*static void Main(string[] args) → entry point of the program.

Square(int x) → normal method to calculate square.

Func<int, int> square = x => x * x; → lambda expression version.

Both print 25 for input 5.*/