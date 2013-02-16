//Write a method that checks if the element at given position in given array of integers is bigger 
//than its two neighbors (when such exist).

using System;

class BiggerThanNeighbours
{
    static void Main()
    {       
        int[] testArray = { 44, 33, 3, 5, 5, 9, 7, 5, 4, 0 };
        int position = 5;
        CheckIfBigger(testArray, position);
    }
    static void CheckIfBigger(int[] testArray, int position)
    {
        if ((testArray.Length == 1) || (position == 0 && testArray[position] > testArray[position + 1]) ||
            (position == testArray.Length - 1 && testArray[position] > testArray[position - 1]) ||
            ((position > 0 && position < testArray.Length - 1) &&
            (testArray[position] > testArray[position - 1]) && (testArray[position] > testArray[position + 1])))
        {
            Console.WriteLine("The element {0} at position {1} IS bigger than its neighbours.", testArray[position], position);

        }
        else
        {
            Console.WriteLine("The element {0} at position {1} is NOT bigger than its neighbours.", testArray[position], position);
        }
    }
}

