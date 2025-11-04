using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        // LINQ query to select even numbers    query method
        var evenNumbers = from n in numbers
                          where n % 2 == 0
                          select n;

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}

//syntax method

/*var evenNumbers = numbers.Where(n => n % 2 == 0);

foreach (var n in evenNumbers)
{
    Console.WriteLine(n);
}
*/