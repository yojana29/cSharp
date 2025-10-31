using System;

enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        Days today = Days.Wednesday;
        Console.WriteLine("Today is: " + today);
        Console.WriteLine("Day number: " + (int)today);//it stores number so it gives 3 starting from 0 and int(today) is typecasting
    }
}
