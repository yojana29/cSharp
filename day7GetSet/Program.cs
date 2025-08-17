using System;


    class Example
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
        }
    }
class Program
{
    static void Main()
    {
        Example E1 = new Example();
        E1.Name = "RAM";
        E1.ShowInfo();
    }
        
    }

