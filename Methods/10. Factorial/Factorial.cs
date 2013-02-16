//Write a program to calculate n! for each n in the range [1..100]. 

using System;
using System.Numerics;

class FactorialN
{
    static void Main()
    {
        Console.WriteLine("Enter n! - from 1 to 100: ");
        int n = int.Parse(Console.ReadLine());

        FactorialCalculation(n);
    }

    private static void FactorialCalculation(int n)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("{0}! = {1}", n, factorial);
    }
}