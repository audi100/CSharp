//* Modify your last program and try to make it work for any number type, not just integer 
//(e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GenericsMethods
{
    static void Main()
    {
        Console.WriteLine("The biggest integer in the big array is:{0}", FindMax(2, 88.555555555555555555555, 6, -3));
        Console.WriteLine("The biggest integer in the small array is:{0}", FindMax(-44, 2));
        Console.WriteLine("The smallest integer in the big array is:{0}", FindMin(2, 88, 6, -3));
        Console.WriteLine("The smallest integer in the small array is:{0}", FindMin(-44.9, 2));     
        Console.WriteLine("The sum in the big array is:{0}", FindSum(2, 88, 6, -3));
        Console.WriteLine("The sum in the small array is:{0}", FindSum(3, 5, 7));
        Console.WriteLine("The average in the big array is:{0:F2}", FindAverage((FindSum(2, 88.55, 6, -3)), 2, 88.55, 6, -3));
        Console.WriteLine("The average in the small array is:{0:F2}", FindAverage((FindSum(-44, 2.0)), -44, 2.0));
        Console.WriteLine("The product in the big array is:{0}", FindProduct(2, 88, 6, -3));
        Console.WriteLine("The product in the small array is:{0}", FindProduct(2, -8.3, 6));
    }
    static T FindMax<T>(params T[] array)
    {
        dynamic biggest=array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>biggest)
            {
                biggest = array[i];
            }
        }
        return biggest;
    }
    static T FindMin<T>(params T[] array)
    {
        dynamic smallest = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < smallest)
            {
                smallest = array[i];
            }
        }
        return smallest;
    }
    static T FindSum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }        
        return sum;
    }
    static T FindAverage<T>(dynamic sum, params T[] array)
    {
        dynamic average = sum / array.Length;
        return average;
    }
    static T FindProduct<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product = product * array[i];
        }
        return product;
    }
}

