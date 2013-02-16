//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
using System;

class CheckIfYearIsLeap
{
    static void Main()
    {
        Console.Write("Please enter year with four digits:");
        int enteredYear = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(enteredYear))
        {
            Console.WriteLine("The year {0} IS leap.", enteredYear); 
        }
        else
        {
            Console.WriteLine("The year {0} is NOT leap.", enteredYear); 
        }
        
    }
}

