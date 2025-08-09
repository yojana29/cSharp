using System;
namespace ClassExample
{
    class Student
    {
        public string name;
        public string address;
        public int age;
        public int rollNo;

        public void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Address:" + address);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("RollNo:" + rollNo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name = "RAM";
            s1.address = "MNR";
            s1.age = 20;
            s1.rollNo = 54;
            s1.ShowInfo();
        }
      
    }
}