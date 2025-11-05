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
       /*Func<int, int> means a function that takes an int and returns an int.

     x => x * x is the lambda expression for squaring a number.*/

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



//lambda expression with collection of objects

/*using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "Asha", Age = 18 },
            new Student { Name = "Rita", Age = 20 },
            new Student { Name = "Sita", Age = 17 }
        };

        // Using Lambda expression with LINQ
        var olderStudents = students.Where(s => s.Age > 18);

        foreach (var s in olderStudents)
        {
            Console.WriteLine(s.Name + " - " + s.Age);
        }
    }
}
s => s.Age > 18 is the lambda expression.

.Where(s => s.Age > 18) filters students older than 18.

This is shorter and simpler than the query syntax.
*/