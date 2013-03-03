//Write a method that from a given array of students finds all students whose first name 
//is before its last name alphabetically. Use LINQ query operators.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class FirstNameBeforeLast
{
    static void Main()
    {
        Student[] students = new Student[] { new Student{ FirstName = "Pesho", LastName = "Ivanov" }, 
            new Student { FirstName = "Assen", LastName = "Georgiev" }, new Student { FirstName = "Ivanka", LastName = "Tsoneva" },
        new Student { FirstName = "Gogo", LastName = "Asenov" },new Student { FirstName = "Niki", LastName = "Kostov" }};

        PrintStudentsWithFirstNameBeforeLast(students);
    }

    private static void PrintStudentsWithFirstNameBeforeLast(Student[] students)
    {
        var studentsFirstBeforeLastName =
        from student in students
        where student.FirstName.CompareTo(student.LastName) < 0
        select student;

        Console.WriteLine("The students whose first name is before its last name alphabetically are:");
        Console.WriteLine(new string('-', 20));
        foreach (var student in studentsFirstBeforeLastName)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            Console.WriteLine(new string('-', 20));
        }
    }
}



