//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class TestGenericExtensionMethods
{
    static void Main()
    {
        List<long> longArr = new List<long>() { 9, -33, 4, 455, -3434, 33 };

        Console.WriteLine("The sum is:    {0,15}"   ,longArr.SumExtension());
        Console.WriteLine("The product is:{0,15}", longArr.ProductExtension());
        Console.WriteLine("The minimum is:{0,15}", longArr.MinExtension());
        Console.WriteLine("The maximum is:{0,15}", longArr.MaxExtension());
        Console.WriteLine("The average is:{0,15:F2}", longArr.AverageExtension());
        Console.WriteLine(new string('-',50));

        int[] intArr = new int[] { 2, -2, 4, -8, -100, 15, 1 };
        Console.WriteLine("The sum is:    {0,15}", intArr.SumExtension());
        Console.WriteLine("The product is:{0,15}", intArr.ProductExtension());
        Console.WriteLine("The minimum is:{0,15}", intArr.MinExtension());
        Console.WriteLine("The maximum is:{0,15}", intArr.MaxExtension());
        Console.WriteLine("The average is:{0,15:F2}", intArr.AverageExtension());
    
    }
}

