using System;

// Define interface
interface IAnimal
{
    void Sound();   // method without body
}

// Implement interface
class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

/*class Program
{
    static void Main()
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();

        dog.Sound();
        cat.Sound();
    }
}*/
/*👉 Interface is used when you want to make sure that different classes
follow the same rule or structure — like all animals must have a Sound() method, but each can make a different sound.*/

//multiple interference
// using System;

// First Interface
interface IPrint
{
    void Print();
}

// Second Interface
interface IScan
{
    void Scan();
}

// Class implementing both interfaces
class Printer : IPrint, IScan
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

class Program
{
    static void Main()
    {
        Printer p = new Printer();
        p.Print();
        p.Scan();
    }
}
