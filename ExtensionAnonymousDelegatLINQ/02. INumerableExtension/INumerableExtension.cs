//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//sum, product, min, max, average.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class IEnumerableExtension
{
    public static T SumExtension<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic sum = 0;
        foreach (var item in input)
        {
            sum += item;
        }
        return sum;
    }
    public static T ProductExtension<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic product = 1;
        foreach (var item in input)
        {
            product *= item;
        }
        return product;
    }
    public static T MinExtension<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic min = input.First();
        foreach (var item in input)
        {
            if (item<min)
            {
                min = item;
            }            
        }
        
        return min;
    }
    public static T MaxExtension<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic max = input.First();
        foreach (var item in input)
        {
            if (item > max)
            {
                max = item;
            }
        }

        return max;
    }
    public static decimal AverageExtension<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic sum = 0;
        decimal counter = 0;
        foreach (var item in input)
        {
           
                sum += item;
                counter++;
        }

        return sum/counter;
    }
    //public static T MinExtension<T>(this IEnumerable<T> elements) where T : IComparable<T>
    //{
    //    int index = 0;
    //    T min = default(T);
    //    foreach (var item in elements)
    //    {
    //        if (index == 0)
    //        {
    //            min = item;
    //        }
    //        else
    //        {
    //            if (item.CompareTo(min) < 0)
    //            {
    //                min = item;
    //            }
    //        }
    //        index++;
    //    }

    //    if (index == 0)
    //    {
    //        throw new ArgumentException("Elements are empty list.");
    //    }
    //    return min;
    //}   
}

