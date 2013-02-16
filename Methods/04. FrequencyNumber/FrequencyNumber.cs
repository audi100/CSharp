//Write a method that counts how many times given number appears in given array. 
//Write a program to check if the method is working correctly.

using System;

class FrequencyNumber
{
    static void Main()
    {
        decimal[] testArray = { 9, 33, 3, 5, 7, 9, 7, 5, 4, 7, -7 };
        decimal testNumber = 7;
        int frequencyCounter = 0;
        CheckFrequency(testArray, testNumber, frequencyCounter);
    }
    static void CheckFrequency(decimal[] testArray, decimal testNumber, int frequencyCounter)
    {
        for (int i = 0; i < testArray.Length; i++)
        {
            if (testArray[i]==testNumber)
            {
                frequencyCounter++;
            }
        }
        Console.WriteLine("The number {0} occurs {1} time/s in the array.",testNumber, frequencyCounter);
    }
}

