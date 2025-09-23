using System;
class Person
{
    public void Hello()
    {
        Console.WriteLine(" My name is Ram.");
    }

}
class Greeting : Person
{
    public void Hello()//hides the base method
    {
        Console.WriteLine(" Hello! Everyone.");
    }
    public void ShowInfo()
    {
        Hello();//calls greeting one 
         base.Hello();//calls person one

    }
}

class Program
{
    static void Main()
    {
        Greeting g = new Greeting();
        g.ShowInfo();
    }
}