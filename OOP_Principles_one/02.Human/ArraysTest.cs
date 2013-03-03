//Define abstract class Human with first name and last name. Define new class Student which is derived 
//from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary 
//and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
//Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students 
//and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


class ArraysTest
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        List<Student> studentList = new List<Student>() {  
        new Student ("Petar", "Hristov", 7),new Student ("Ivan", "Petrov", 12),
        new Student ("Kiril", "Kirov", 3),new Student ("Ivan", "Georgiev", 4),
        new Student ("Petar", "Kovachev", 8), new Student ("Alexander", "Lipov", 10),
        new Student ("Petar", "Stoychev", 6), new Student ("Ivo", "Ivanov", 5),
        new Student ("Kalin", "Kostov", 9), new Student ("Iliya", "Mitev", 11)};

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Sorted Students by Grade ascending:");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("{0,10} {1,10} {2,10}","First Name","LastName","Grade");
        Console.WriteLine(new string('-', 50));

        var sortedStudents = studentList.OrderBy(x => x.Grade);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine("{0,10} {1,10} {2,10}",student.FirstName,student.LastName,student.Grade);
        }

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Sorted Workers by money earned per hour descending:");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("{0,10} {1,10} {2,10}", "First Name", "LastName", "Money per Hour");
    
        Console.WriteLine(new string('-',50));
        List<Worker> workerList = new List<Worker>() {  
        new Worker ("Hristo", "Petrov", 700,8),new Worker ("Konstantin", "Dimchev", 120,4),
        new Worker ("Valeri", "Kalinov", 300,2),new Worker ("Georgi", "Dimitrov", 400,8),
        new Worker ("Atanas", "Kotsev", 230, 8), new Worker ("Dimitar", "Asenov", 220, 10),
        new Worker ("Assen", "Koychev", 350, 8), new Worker ("Lilyan", "Stamatov", 280,6),
        new Worker ("Kalin", "Kirilov", 380, 9), new Worker ("Iliya", "Bozhkov", 420, 11)};

        var sortedWorkers = workerList.OrderByDescending(x => x.MoneyPerHour(x.WeekSalary, x.WorkHoursPerDay));
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine("{0,10} {1,10} {2,10:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay));
        }

        List<Human> humanList = new List<Human>();
        humanList.AddRange(studentList);
        humanList.AddRange(workerList);

        var sortedHuman = humanList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Sorted Human by First Name and Last Name:");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("{0,10} {1,10}", "First Name", "LastName");

        foreach (var human in sortedHuman)
        {
            Console.WriteLine("{0,10} {1,10}", human.FirstName, human.LastName);
        }
        Console.WriteLine(new string('-', 50));
    }
}

