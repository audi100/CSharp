//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461

using System;

class SumOfIntegers
{
    static void Main()
    {
        string severalIntegers = "65 455 4 3 4 9";
        Console.WriteLine("result={0}", CalculateSum(severalIntegers));
    }
    static int CalculateSum(string severalIntegers)
    {
        string[] arr = severalIntegers.Split(' ');
        int sumOfintegers = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sumOfintegers = sumOfintegers + int.Parse(arr[i].Trim());
        }
        return sumOfintegers;
    }
}

