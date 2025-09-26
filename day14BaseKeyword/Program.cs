using System;
class Person//base class
{
    public string Name = "Base: Ram";
}
class Student : Person //derived class
{
    public string Name = "Derived: Hari";

    public void showDetail()
    {
        Console.WriteLine(Name);//refers to name of derived class
        Console.WriteLine(base.Name);//refers to name base class
    }
}
class Program
{
    static void Main()
    {
        Student s = new Student();
        s.showDetail();
    }
}