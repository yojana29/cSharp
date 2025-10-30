using System;

class Person
{
    public virtual void Show()   // ✅ base class method marked virtual
    {
        Console.WriteLine("This is Person class method.");
    }
}

class Student : Person
{
    public override void Show()   // ✅ overriding the base method
    {
        Console.WriteLine("This is Student class method.");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Show();   // Calls derived class method

        Person p = new Person();
        p.Show();   // Calls base class method

        // Upcasting (base class reference pointing to derived object)
        Person ps = new Student();
        ps.Show();   // Calls derived class method (runtime polymorphism)
    }
}
