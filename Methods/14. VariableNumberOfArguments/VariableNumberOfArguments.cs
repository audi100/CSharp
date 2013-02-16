//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.

using System;

class VariableNumberOfArguments
{
    static void Main()
    {
        Console.WriteLine("The biggest integer in the big array is:{0}", FindMax(2, 88, 6, -3));
        Console.WriteLine("The biggest integer in the small array is:{0}", FindMax(-44,2));
        Console.WriteLine("The smallest integer in the big array is:{0}", FindMin(2, 88, 6, -3));
        Console.WriteLine("The smallest integer in the small array is:{0}", FindMin(-44, 2));
        Console.WriteLine("The average in the big array is:{0:F2}", FindAverage((FindSum(2, 88, 6, -3)),2,88,6,-3));
        Console.WriteLine("The average in the small array is:{0:F2}", FindAverage((FindSum(-44, 2)),-44,2));
        Console.WriteLine("The sum in the big array is:{0}", FindSum(2, 88, 6, -3));
        Console.WriteLine("The sum in the small array is:{0}", FindSum(3,5,7));
        Console.WriteLine("The product in the big array is:{0}", FindProduct(2, 88, 6, -3));
        Console.WriteLine("The product in the small array is:{0}", FindProduct(2,-8,6));
    }
    static int FindMax(params int[] array)
    {
        int biggest=array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>biggest)
            {
                biggest = array[i];
            }
        }
        return biggest;
    }
    static int FindMin(params int[] array)
    {
        int smallest = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < smallest)
            {
                smallest = array[i];
            }
        }
        return smallest;
    }
    static double FindSum(params int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }        
        return sum;
    }
    static double FindAverage(double sum, params int[] array)
    {
        double average = (double)sum / (double)array.Length;
        return average;
    }
    static int FindProduct(params int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product = product * array[i];
        }
        return product;
    }
}