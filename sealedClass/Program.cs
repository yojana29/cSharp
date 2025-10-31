using System;

sealed class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}

// class AdvancedCalc : Calculator { }  Not allowed

class Program
{
    static void Main()
    {
        Calculator c = new Calculator(); // ✅ allowed
        c.Add(5, 10);
    }
}
