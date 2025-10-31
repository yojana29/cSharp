using System;

abstract class Animal
{
    public abstract void Sound();//abstract method with no body
    public void Eat()
    {
        Console.WriteLine("This animal eats food.");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks.");
    }
}
class Program
{
    static void Main()
    {
        //Animal a = new Animal(); Not allowed(abstract class)
        Dog d = new Dog();
        d.Eat();
        d.Sound();
    }
}