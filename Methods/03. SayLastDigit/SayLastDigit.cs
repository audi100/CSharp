//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".
using System;

class SayLastDigit
{
    static void Main()
    {
        Console.WriteLine("Please enter integer.");
        int number = int.Parse(Console.ReadLine());
        SayLastDigitMethod(number);
    }
    static void SayLastDigitMethod(int number)
    {
        int lastDigit = Math.Abs(number % 10);
        switch (lastDigit)
        {
            case 0: Console.WriteLine("{0}-->zero", number); break;
            case 1: Console.WriteLine("{0}-->one", number); break;
            case 2: Console.WriteLine("{0}-->two", number); break;
            case 3: Console.WriteLine("{0}-->three", number); break;
            case 4: Console.WriteLine("{0}-->four", number); break;
            case 5: Console.WriteLine("{0}-->five", number); break;
            case 6: Console.WriteLine("{0}-->six", number); break;
            case 7: Console.WriteLine("{0}-->seven", number); break;
            case 8: Console.WriteLine("{0}-->eight", number); break;
            case 9: Console.WriteLine("{0}-->nine", number); break;
        }
    }
}
