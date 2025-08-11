using System;

class Student
{
    private string name;   // private field

    // Public property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Show()
    {
        Console.WriteLine("Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();

        // Set value using property
        s1.Name = "Sita";

        // Get value using method
        s1.Show();
    }
}
