//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMax3Int
{
    static void Main()
    {
        Console.WriteLine("Please enter the first integer.");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second integer.");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third integer.");
        int third = int.Parse(Console.ReadLine());
        int biggest = GetMax(GetMax(first, second), third);
        Console.WriteLine("The biggest number is:{0}", biggest);
    }
    static int GetMax(int first, int second)
    {
        if (first>second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }    
}

