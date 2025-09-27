using System;
class Person
{
    public void Show()
    {
        Console.WriteLine("This is the method of the base class.");
    }
}

class Student : Person
{
    public new void Show()//hides the base class method
    {
        Console.WriteLine("This is the method of derives class.");
    }
}

class Program
{
    static void Main()
    {

        Student s = new Student();
        s.Show();//calls derived class

        Person p = new Person();
        p.Show();//calls base class

        // Upcasting: Base class reference to derived object
        Person ps = new Student();
        ps.Show();//call base class method
    
    }
}