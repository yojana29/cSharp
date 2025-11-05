using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b; // This will throw DivideByZeroException
            Console.WriteLine(result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        finally
        {
            Console.WriteLine("Execution of try-catch block finished.");
        }
    }
}
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // This line throws IndexOutOfRangeException
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Array index is out of range");
        }
        catch (Exception ex) // Handles any other kind of exception
        {
            Console.WriteLine("Some other error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program ended safely.");
        }
    }
}
*/
