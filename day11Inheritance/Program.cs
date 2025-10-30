using System;

class Person  //baseclass
{
    public string Name;
    public int age;
    public void showInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + age);
    }
}

class Student : Person //derived class
{
    public string College;

    public void showDetails()
    {
        Console.WriteLine("College: " + College);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student(); //object from derived class
        //Inherited from Person (Base Class)
        
        s.Name = "Ram";
        s.age = 20;
        s.showInfo(); //Calling Base class method

        //Own property of Student
        s.College = "Siddhanath Science Campus";

        //Callinf Derived class Method
        s.showDetails();
    }
}