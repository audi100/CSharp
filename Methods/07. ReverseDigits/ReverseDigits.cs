//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class ReverseDigits
{
    static void Main()
    {
        Console.Write("Please enter number:");
        string decimalStr = Console.ReadLine();
        ReverseDigitsOfDecimalNumber(decimalStr);
    }
    static void ReverseDigitsOfDecimalNumber(string decimalStr)
    {
        bool isNegative=false;
        char[] reverseDigits = decimalStr.ToCharArray();
        Console.Write("The reversed number is:");
        if (reverseDigits[0] == '-')
        {
            Console.Write('-');
            isNegative = true;
        }
        Array.Reverse(reverseDigits);
        
        for (int i = 0; i < reverseDigits.Length; i++)
        {
            if (isNegative == true && i == reverseDigits.Length - 1)
            {
                break;
            }
            Console.Write(reverseDigits[i]);
        }
        Console.WriteLine();
    }  
}

