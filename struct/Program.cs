using System;

struct Student
{
    public string Name;
    public int Age;

    // Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Ram", 20);  // Creating struct object
        s1.ShowInfo();
    }
}
