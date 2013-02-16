//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ArraysOfDigits  
{
    static void Main()
    {
        byte[] num1 = { 0, 1 ,1, 1};//1110
        byte[] num2 = { 9, 9, 9 };//999
        PrintArray(SumDigits(num1, num2));
        Console.WriteLine();
    }
    static void PrintArray(List<int> list)
    {
        list.Reverse();
        foreach (var item in list)
        {
            Console.Write(item);
        }
    }
    static List<int> SumDigits(byte[] a, byte[] b)
    {
        var result = new List<int>();
        int mind = 0;
        int len = Math.Max(a.Length, b.Length);
        for (int i = 0; i < len; i++)
        {
            int digit = (i < a.Length ? a[i] : (byte)0) + (i < b.Length ? b[i] : (byte)0) + mind;
            mind = digit / 10;
            result.Add(digit % 10);
        }
        if (mind == 1) result.Add(1);
        return result;
    }

}