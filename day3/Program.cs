using System;
namespace Operations
{
    class Addition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first numbers: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second Number: ");
            int y = int.Parse(Console.ReadLine());

            int sum = x + y;
            Console.WriteLine($"The Sum of {x} and {y} is {sum}");

            int subtract = x - y;
            Console.WriteLine($"The difference of {x} and {y} is {subtract}");

            int mul = x * y;
            Console.WriteLine($"The multiplication of {x} and {y} is {mul}");

            int div = x / y;
            Console.WriteLine($"The division of {x} and {y} is {div}");


        }
    }
}