//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class TenRandomNumbers
{
    static void Main()
    {
        Random randomGenerator = new Random();

        for (int counter = 1; counter <= 10; counter++)
        {
            Console.WriteLine(randomGenerator.Next(100, 201)); 
        }       
    }
}

