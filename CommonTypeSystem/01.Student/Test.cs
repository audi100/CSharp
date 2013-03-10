//1.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
//mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, 
//universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(),
//GetHashCode() and operators == and !=.
//2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a 
//new object of type Student.
//3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
//and by social security number (as second criteria, in increasing order).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Test
{
    static void Main()
    {
        Student first = new Student("Boyan", "Hristov", "Georgiev", 123, "Sofia, 48, Vasil Levski Blvd", 
            "98888888", "boyan@abv.bg", University.UNSS, Faculty.IT, Specialty.ComputerSystems, 1);
        
        Console.WriteLine("Original:"+first);

        Student cloned = first.Clone();
        
        Console.WriteLine("Cloned:{0}", cloned);

        Console.WriteLine("First and Cloned are the same students: {0}", first.Equals(cloned));

        Console.WriteLine(new string('-', 50));

        cloned.SSN = 2323;
        Console.WriteLine("Cloned :{0} with changed SSN", cloned);
        Console.WriteLine("Original of the cloned {0}", first);

        Console.WriteLine("First and Cloned are the same students after the change of SSN of cloned: {0}", first.Equals(cloned));
        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Other three students:");
        Student second = new Student("Ivanka", "Ivanova", "Kancheva", 12111, "Sofia, 64, Hristo Botev Blvd",
            "088888128", "ivanka@abv.bg", University.TU, Faculty.Biology, Specialty.Chemistry, 2);
        Console.WriteLine(second);
        Student third = new Student("Penka", "Mincheva", "Manolova", 23400, "Sofia, 44, Hristo Botev Blvd",
            "088888123", "penka@abv.bg", University.TU, Faculty.Biology, Specialty.Chemistry, 2);
        Console.WriteLine(third);
        Student fourth = new Student("Anna", "Georgieva", "Manova", 4646, "Sofia, 44, Hristo Botev Blvd",
           "088888123", "penka@abv.bg", University.TU, Faculty.Biology, Specialty.Chemistry, 2);
        Console.WriteLine(fourth);

        List<Student> sortedStudents = new List<Student>();
        sortedStudents.Add(first);
        sortedStudents.Add(second);
        sortedStudents.Add(cloned);
        sortedStudents.Add(third);
        sortedStudents.Add(fourth);

        sortedStudents.Sort();

        Console.WriteLine(new string('-',50));
        Console.WriteLine("The sorted students are:");

        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
    }
}

