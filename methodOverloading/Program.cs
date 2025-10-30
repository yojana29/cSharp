using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();

        Console.WriteLine(c.Add(5, 10));        // calls first method
        Console.WriteLine(c.Add(5.5, 6.5));     // calls second method
        Console.WriteLine(c.Add(1, 2, 3));      // calls third method
    }
}
//In this the compiler decides which method to call based on the arguments passed and happens during compilation
