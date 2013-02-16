//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye".
//Use try-catch-finally.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CalcSquareRoot
{
    static void Main()
    {
        Console.Write("Please enter positive integer:");
        string integerNum = Console.ReadLine();
        CalculateSquareRoot(integerNum);
        
    }
    static void CalculateSquareRoot(string integerNum)
    {
        try
        {
            int number = int.Parse(integerNum);
            if (number<0)
            {
                throw new FormatException();
            }
            Console.WriteLine("The square root is:{0}",(int)Math.Sqrt(number)); 
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number! ");

        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number! ");

        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number! ");

        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
       
    }
}

