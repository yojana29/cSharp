using System;
class Person
{
    public string Name;
    //base class constructor
    public Person(string name)
    {
        Name = name;
    }
}

class Details : Person
{
    public string College;

    //derived class constructor
    public Details(string name, string college) : base(name)//calling base constructor using base keyword
    {
        College = college;
    }
    public void showDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("College: " + College);
    }
}

class Program
{
    static void Main()
    {
        Details D = new Details("Ram", "Siddhanath Science Campus");
        D.showDetails();
    }
}