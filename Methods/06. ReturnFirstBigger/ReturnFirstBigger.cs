//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
//if there’s no such element.

using System;

class ReturnFirstBigger
{
    static void Main()
    {
        bool biggerExists = false;
        int[] testArray = { 1, 1, 1, 1, 99, 1, 99 };
        int position;

        for (position = 0; position < testArray.Length; position++)
        {

            if (CheckIfBigger(testArray, position, biggerExists))
            {
                break;
            }

            else if (position == testArray.Length - 1)
            {
                Console.WriteLine("-1");
            }
        }
    }
    static bool CheckIfBigger(int[] testArray, int position, bool biggerExists)
    {
        if ((testArray.Length == 1)||(position == 0 && testArray[position] > testArray[position + 1])||
            (position == testArray.Length - 1 && testArray[position] > testArray[position - 1])||
            ((position > 0 && position < testArray.Length - 1) &&
            (testArray[position] > testArray[position - 1]) && (testArray[position] > testArray[position + 1])))
        {
            Console.WriteLine(position);
            return true;
        }
        else
        {
            return false;
        }
    }
}

