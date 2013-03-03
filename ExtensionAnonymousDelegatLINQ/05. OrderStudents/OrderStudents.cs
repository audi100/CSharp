//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and
//last name in descending order. Rewrite the same with LINQ.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class OrderStudents
{
    static void Main()
    {
        var students = new[] { new { FirstName = "Pesho", LastName = "Ivanov", Age=19 }, 
            new { FirstName = "Assen", LastName = "Georgiev", Age=25 }, new { FirstName = "Ivanka", LastName = "Tsoneva", Age=36 },
        new { FirstName = "Gogo", LastName = "Asenov", Age=22 },new { FirstName = "Niki", LastName = "Kostov", Age=21 },
        new { FirstName = "Ivanka", LastName = "Asenova", Age=21 }};

        
        var sortedStudentsLambda = students.OrderByDescending(student => student.FirstName).ThenByDescending(student=>student.LastName);

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("The students sorted with lambda expressions are:");
        Console.WriteLine(new string('-', 50));

        foreach (var student in sortedStudentsLambda)
        {
            Console.WriteLine("First Name: {0,-10} Last Name: {1,-10} Age: {2,-10}", student.FirstName, student.LastName, student.Age);
        }

        Console.WriteLine(new string('-',50));
        var sortedStudentsLINQ = from student in students
                                 orderby student.FirstName descending, student.LastName descending
                                 select student;
        Console.WriteLine("The students sorted with LINQ are:");
        Console.WriteLine(new string('-', 50));
        foreach (var student in sortedStudentsLINQ)
        {
            Console.WriteLine("First Name: {0,-10} Last Name: {1,-10} Age: {2,-10}", student.FirstName, student.LastName, student.Age);
        }
    }
}

