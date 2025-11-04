
//just an example for collection of object using LINQ

using System;
using System.Collections.Generic;
using System.Linq;  // Required for LINQ

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Name = "Asha", Age = 18 },
            new Student { Name = "Rita", Age = 20 },
            new Student { Name = "Sita", Age = 17 }
        };

        // Get students older than 18 using LINQ
        var olderStudents = from s in students
                            where s.Age > 18
                            select s;

        foreach (var s in olderStudents)
        {
            Console.WriteLine(s.Name + " - " + s.Age);
        }
    }
}
