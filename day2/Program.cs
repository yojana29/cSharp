using System;

namespace PrintNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter 'odd' or 'even': ");
            string type = Console.ReadLine();
            Console.Write("How many number do you want to print?");
            int n = int.Parse(Console.ReadLine());
            int start = (type == "even") ? 2 : 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(start + i * 2 + " ");

            }
            Console.WriteLine();

        }
    }
}