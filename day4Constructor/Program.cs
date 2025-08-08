using System;
//parameteriszed constructor
namespace ClassObject
{
    class Details
    {
        string Name;
        int Age;
        public Details(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

    }

    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Details s1 = new Details("Ram", 20);
    //         s1.ShowInfo();

    //     }
    // }

    namespace DefaultConstructor
    {
        class Information
        {
            private string StdName;
            private int RollNo;

            public Information()
            {
                StdName = "Hari";
                RollNo = 1234;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {StdName} and RollNo: {RollNo} ");
            }
        }

        class SecondProgram
        {
            static void Main()
            {
                Information I1 = new Information();
                I1.DisplayInfo();
            }
        }
    }
}