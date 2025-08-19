using System;

namespace Arrays
{
    class ArrayExample
    {
        static void Main()
        {
            int[] numbers = {10, 20, 30, 40, 50 };

            //printing element using index
            Console.WriteLine("/First Element" + numbers[0]);

            //printing all elements
            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine($"{i} element" + numbers[i]);
            }
        }
    }
}