//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class StudentsAged18_24
{
    static void Main(string[] args)
    {
        var students = new[] { new { FirstName = "Pesho", LastName = "Ivanov", Age=19 }, 
            new { FirstName = "Assen", LastName = "Georgiev", Age=25 }, new { FirstName = "Ivanka", LastName = "Tsoneva", Age=36 },
        new { FirstName = "Gogo", LastName = "Asenov", Age=22 },new { FirstName = "Niki", LastName = "Kostov", Age=21 }};

        var students18_24 =
        from student in students
        where student.Age <= 24 && student.Age >= 18
        select student;

        Console.WriteLine("The students whose age is between 18 and 24 are:");
        Console.WriteLine(new string('-', 20));
        foreach (var studentYoung in students18_24)
        {
            Console.WriteLine("{0,5} {1,5} {2,3}", studentYoung.FirstName, studentYoung.LastName, studentYoung.Age);
            Console.WriteLine(new string('-', 20));
        }
    }
}
