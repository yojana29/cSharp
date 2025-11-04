using System;

// A generic class — T is a placeholder for any data type
class Box<T>
{
    private T value;

    // Store value
    public void Add(T item)
    {
        value = item;
    }

    // Get value
    public void Show()
    {
        Console.WriteLine("Value: " + value);
    }
}

class Program
{
    static void Main()
    {
        // Box for integer
        Box<int> intBox = new Box<int>();
        intBox.Add(100);
        intBox.Show();   // Output: Value: 100

        // Box for string
        Box<string> strBox = new Box<string>();
        strBox.Add("Hello World");
        strBox.Show();   // Output: Value: Hello World

        // Box for double
        Box<double> dblBox = new Box<double>();
        dblBox.Add(99.99);
        dblBox.Show();   // Output: Value: 99.99
    }
}
