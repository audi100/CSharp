//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class ReturnMaxElement
{
    static void Main()
    {
        int[] Array = new int[] { 6, -2, 8, -99, 33, 0 };
        int position = 0;

        Console.Write("The unsorted array is: ");
        PrintArray(Array);

        int exchange=int.MinValue;
        int biggest = 0;
        int positionBiggest = 0;
        
        SortDescending(Array, position, ref biggest, ref positionBiggest, exchange);  

        Console.WriteLine();
        Console.Write("The sorted array in descending order is:   ");
        PrintArray(Array);
        Console.WriteLine();
        Console.Write("The sorted array in ascending order is:   ");
        PrintArrayReversed(Array);
        Console.WriteLine();
    }

    static int FindMaxElement(int[] Array, int position, ref int biggest, ref int positionBiggest)
    {
        for (int j = position; j < Array.Length; j++)
        {
            if (j == position)
            {
                biggest = Array[position];
                positionBiggest = position;
            }

            if (Array[j] > biggest)
            {
                biggest = Array[j];
                positionBiggest = j;
            }
            
        }
        return positionBiggest;
    }
    static int[] SortDescending(int[] Array, int position, ref int biggest, ref int positionBiggest, int exchange)
    {
        while (position < Array.Length)
        {
            for (int j = position; j < Array.Length; j++)
            {
                FindMaxElement(Array, position, ref biggest, ref positionBiggest);
                if (j == Array.Length - 1)
                {
                    exchange = Array[position];
                    Array[position] = Array[positionBiggest];
                    Array[positionBiggest] = exchange;
                }
            }
            position++;
        }
        return Array;
    }
    
    static void PrintArray(int[] Array)
    {
        foreach (int element in Array)
        {
            Console.Write(element + " ");
        }
    }
    static void PrintArrayReversed(int[] ArrayInt)
    {
        Array.Reverse(ArrayInt);
        foreach (int element in ArrayInt)
        {
            Console.Write(element + " ");
        }
    }
}

